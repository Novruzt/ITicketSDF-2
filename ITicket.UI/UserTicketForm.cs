using ITicket.DAL.Repository.Concrete;
using ITicket.Entity.Entities;
using ITicket.UI.Extensions;
using Microsoft.IdentityModel.Tokens;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using User = ITicket.Entity.Entities.User;

namespace ITicket.UI
{
    public partial class UserTicketForm : Form
    {
        private User _user;
        private UserRepository _userRepository;
        private TicketRepository _ticketRepository;
        private UserTicketRepository _userTicketRepository;
        public UserTicketForm(User user)
        {
            InitializeComponent();
            _user = user;
            _userRepository = new UserRepository();
            _ticketRepository = new TicketRepository();
            _userTicketRepository = new UserTicketRepository();
        }
        private void UserTicketForm_Load(object sender, EventArgs e)
        {
            comboTicketType.InitalizeEventTypeComboBox();
            comboPrice.InitalizePriceComboBox();
            comboDate.InitalizeDateComboBox();
            
            List<UserTicket> userTickets = _userTicketRepository
                .Include(t=>t.Ticket)
                .Where(c=>c.UserId==_user.Id).ToList();

            List<Ticket> tickets = new List<Ticket>();

            foreach(UserTicket userTicket in userTickets) 
            {
                Ticket ticket = userTicket.Ticket;

                tickets.Add(ticket);
            }

            tickets = tickets.Where(t => t.EventDate > DateTime.Now).OrderBy(t => t.EventDate).ToList();

            dgwTicket.AutoGenerateColumns = false;

            dgwTicket.Columns.Add("Name", "Name");
            dgwTicket.Columns.Add("TicketType", "Ticket Type");
            dgwTicket.Columns.Add("EventDate", "Event Date");
            dgwTicket.Columns.Add("Price", "Price");
            dgwTicket.Columns.Add("Number", "Number");

            for(int i=0; i<tickets.Count; i++) 
            {
                dgwTicket.Rows.Add(tickets[i].Name, tickets[i].TicketType, tickets[i].EventDate, tickets[i].Price, userTickets[i].Number);
            }        
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<UserTicket> userTickets = _userTicketRepository
                .Include(t => t.Ticket)
                .Where(c => c.UserId == _user.Id).ToList();

            List<Ticket> tickets = new List<Ticket>();

            foreach (UserTicket userTicket in userTickets)
            {
                Ticket ticket = userTicket.Ticket;

                tickets.Add(ticket);
            }

            tickets = tickets.Where(t => t.EventDate > DateTime.Now).OrderBy(t => t.EventDate).ToList();

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

            if (comboDate.SelectedIndex == 0)
                tickets = tickets.OrderBy(t => t.EventDate).ToList();
            else if (comboDate.SelectedIndex == 1)
                tickets = tickets.OrderByDescending(t => t.EventDate).ToList();

            if (!ticketName.IsNullOrEmpty())
            {
                tickets = tickets.Where(t => t.Name.ToLower().Contains(ticketName)).ToList();
            }

            dgwTicket.Rows.Clear();

            for (int i = 0; i < tickets.Count; i++)
            {
                dgwTicket.Rows.Add(tickets[i].Name, tickets[i].TicketType, tickets[i].EventDate, tickets[i].Price, userTickets[i].Number);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ProfileForm form = new ProfileForm(_user);
            form.Show();
            this.Hide();

        }
    }
}