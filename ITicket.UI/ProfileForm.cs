using ITicket.DAL.Repository.Concrete;
using ITicket.Entity.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITicket.UI
{
    public partial class ProfileForm : Form
    {
        private User _user;
        private UserRepository _UserRepository;
        public ProfileForm(User user)
        {
            InitializeComponent();
            _UserRepository = new UserRepository();
            _user = user;
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text.Trim() == "" || txtPassword.Text.Trim().Length <= 1)
            {
                MessageBox.Show("Enter new password");
                return;
            }

            _user.Password = txtPassword.Text;
            _UserRepository.Update(_user);
            MessageBox.Show("Password changed");
        }

        private void btnChangeEmail_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text.Trim() == "" || txtEmail.Text.Trim().Length <= 1)
            {
                MessageBox.Show("Enter email");
                return;
            }

            User dbUser = _UserRepository.Where(c => c.Email == txtEmail.Text).FirstOrDefault();

            if (dbUser != null)
            {
                MessageBox.Show("This email is already used");
                return;
            }

            _user.Email = txtEmail.Text;
            _UserRepository.Update(_user);

            MessageBox.Show("Email changed");
        }

        private void btnTicket_Click(object sender, EventArgs e)
        {
            TicketBuyForm form = new TicketBuyForm(_user);
            form.Show();
            this.Hide();
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            lblEmail.Text = _user.Email;
            lblName.Text = _user.Name;
            lblUsername.Text = _user.Username;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            MainForm form = new MainForm();
            form.Show();
            this.Hide();
        }

        private void btnUserTickets_Click(object sender, EventArgs e)
        {
            UserTicketForm form = new UserTicketForm(_user);
            form.Show();
            this.Hide();
        }
    }
}
