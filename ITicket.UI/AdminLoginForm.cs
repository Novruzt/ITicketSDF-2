using ITicket.DAL.Repository.Concrete;
using ITicket.Entity.Entities;
using ITicket.Entity.Enums;
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
    public partial class AdminLoginForm : Form
    {
        private UserRepository _userRepository;
        public AdminLoginForm()
        {
            InitializeComponent();
            _userRepository = new UserRepository();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainForm form = new MainForm();
            form.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Trim() == "" || txtUsername.Text.Trim().Length <= 1)
            {
                MessageBox.Show("Enter username");
                return;
            }

            if (txtPassword.Text.Trim() == "" || txtPassword.Text.Trim().Length <= 1)
            {
                MessageBox.Show("Enter email");
                return;
            }

            User dbUser = _userRepository.Where(c => c.Username == txtUsername.Text && c.Password == txtPassword.Text && c.UserRole!=UserRole.User).FirstOrDefault();

            if (dbUser == null)
            {
                MessageBox.Show("Username or password is wrong.");
                return;
            }

            MessageBox.Show("You login succesffully.");
        }
    }
}
