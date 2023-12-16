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
    public partial class RegisterForm : Form
    {
        private UserRepository _userRepository;
        public RegisterForm()
        {
            InitializeComponent();
            _userRepository = new UserRepository();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            if (txtUsername.Text.Trim() == "" || txtUsername.Text.Trim().Length <= 1)
            {
                MessageBox.Show("Enter username");
                return;
            }

            if (txtEmail.Text.Trim() == "" || txtEmail.Text.Trim().Length <= 1)
            {
                MessageBox.Show("Enter email");
                return;
            }

            if (txtPassword.Text != txtPasswordAgain.Text)
            {
                MessageBox.Show("Password must be same");
                return;
            } 

            User dbUser = _userRepository.FirstOrDefault(c => c.Username == txtUsername.Text || c.Email == txtEmail.Text);

            if (dbUser != null)
            {
                MessageBox.Show("this email or username already used");
                return;
            }


            User user = new User()
            {
                Name = txtUsername.Text,
                Username = txtUsername.Text,
                Password = txtPassword.Text,
                Email = txtEmail.Text,
                UserRole = UserRole.User
            };

            _userRepository.Add(user);
            MessageBox.Show("New user created");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainForm form = new MainForm();
            form.Show();
            this.Hide();
        }
    }
}
