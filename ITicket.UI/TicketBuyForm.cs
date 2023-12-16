using ITicket.DAL.Repository.Concrete;
using ITicket.Entity.Entities;
using ITicket.Entity.Enums;
using ITicket.UI.Extensions;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITicket.UI
{
    public partial class TicketBuyForm : Form
    {
        private UserRepository _userRepository;
        private User _user;
        private TicketRepository _ticketRepository;
        private UserTicketRepository _userTicketRepository;
        public TicketBuyForm(User user)
        {
            InitializeComponent();
            _user = user;
            _userRepository = new UserRepository();
            _ticketRepository = new TicketRepository();
            _userTicketRepository = new UserTicketRepository();
        }

        private void TicketBuyForm_Load(object sender, EventArgs e)
        {
            comboTicketType.InitalizeEventTypeComboBox();
            comboNumber.InitalizeNumberComboBox();
            comboPrice.InitalizePriceComboBox();

            List<Ticket> tickets = _ticketRepository.Where(t=>t.EventDate>DateTime.Now);

            dgwTicket.AutoGenerateColumns = false;

            dgwTicket.Columns.Add("Name", "Name");
            dgwTicket.Columns.Add("TicketType", "Ticket Type");
            dgwTicket.Columns.Add("EventDate", "Event Date");
            dgwTicket.Columns.Add("Price", "Price");

            foreach (Ticket ticket in tickets)
            {
                dgwTicket.Rows.Add(ticket.Name, ticket.TicketType, ticket.EventDate, ticket.Price);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ProfileForm form = new ProfileForm(_user);
            form.Show();
            this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<Ticket> tickets = new List<Ticket>();

            double price;
            bool IsPrice = double.TryParse(txtPrice.Text, out price);

            if (!IsPrice)
                price = 0;

            if (comboTicketType.SelectedIndex == 0)
                tickets = _ticketRepository.GetAll();
            else
                tickets = _ticketRepository.Where(c => (int)c.TicketType == comboTicketType.SelectedIndex);

            if (comboPrice.SelectedIndex == 0)
                tickets = tickets.Where(c => c.Price >= price).ToList();
            else
                tickets = tickets.Where(c => c.Price <= price).ToList();

            tickets = tickets.Where(t => t.EventDate > DateTime.Now).ToList();

            string ticketName = txtTicketName.Text.Trim().ToLower();
            if (!ticketName.IsNullOrEmpty())
            {
                tickets = tickets.Where(t => t.Name.ToLower().Contains(ticketName)).ToList();
            }

            dgwTicket.Rows.Clear();

            foreach (Ticket ticket in tickets)
            {
                dgwTicket.Rows.Add(ticket.Name, ticket.TicketType, ticket.EventDate, ticket.Price);
            }
        }

        private void btnBuyTicket_Click(object sender, EventArgs e)
        {
            _userRepository.BeginTransaction();
            try
            {
                string ticketName = "";

                if (dgwTicket.SelectedRows.Count > 0)
                {
                    for (int i = 0; i < int.Parse(comboNumber.Text); i++)
                    {
                        ticketName = dgwTicket.SelectedRows[0].Cells[0].Value.ToString();

                        if (ticketName != null)
                        {
                            Ticket ticket = _ticketRepository.Where(t => t.Name == ticketName).FirstOrDefault();

                            UserTicket existingUserTicket = _userTicketRepository
                                .FirstOrDefault(ut => ut.UserId == _user.Id && ut.TicketId == ticket.Id);

                            if (existingUserTicket != null)
                            {
                                if (existingUserTicket.Number > 5)
                                {
                                    MessageBox.Show("You cannot buy this ticket. Because, you owns maximum amount of certain ticket");
                                    return;
                                }

                                existingUserTicket.Number++;
                                _userTicketRepository.Update(existingUserTicket);
                            }
                            else
                            {
                                UserTicket userTicket = new UserTicket()
                                {
                                    UserId = _user.Id,
                                    TicketId = ticket.Id,
                                    Number = 1
                                };

                                _user = _userRepository.Include(u => u.UserTickets).Where(u => u.Id == _user.Id).FirstOrDefault();

                                _userTicketRepository.Add(userTicket);
                                _user.UserTickets.Add(userTicket);
                            }
                        }
                    }

                    MessageBox.Show("Tickets successfully purchased. " + ticketName + " " + (comboNumber.SelectedIndex + 1) + " times.");
                }
                else
                {
                    MessageBox.Show("Select a ticket from the DataGridView to buy.");
                }
            }
            catch
            {
                _userRepository.RollBackTransaction(null);
            }
            finally
            {
                _userRepository.CommitTransaction(null);
            }

        }

        private void comboTicketType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
