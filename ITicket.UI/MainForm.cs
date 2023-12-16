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
    public partial class MainForm : Form
    {
       private UserRepository _userRepository;
        public MainForm()
        {
            InitializeComponent();
            _userRepository = new UserRepository();
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
                MessageBox.Show("Enter password");
                return;
            }

            User dbUser = _userRepository.Where(c=>c.Username==txtUsername.Text && c.Password==txtPassword.Text).FirstOrDefault();

            if(dbUser == null)
            {
                MessageBox.Show("Username or password is wrong.");
                return;
            }

            ProfileForm form = new ProfileForm(dbUser);
            form.Show();
            this.Hide();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm form = new RegisterForm();
            this.Hide();
            form.Show();
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            ResetPasswordForm form = new ResetPasswordForm();
            this.Hide();
            form.Show();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            AdminLoginForm form = new AdminLoginForm();
            form.Show();
            this.Hide();        
        }
    }
}
