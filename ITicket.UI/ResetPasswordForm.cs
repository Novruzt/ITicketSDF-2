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
    public partial class ResetPasswordForm : Form
    {
        private UserRepository _userRepository;
        public ResetPasswordForm()
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

            if (dbUser == null)
            {
                MessageBox.Show("Please, enter valid username and email.");
                return;
            }

            dbUser.Password = txtPassword.Text;
            _userRepository.Update(dbUser);
            MessageBox.Show("Password resetted");

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainForm form = new MainForm();
            form.Show();
            this.Hide();
        }
    }
}
