namespace ITicket.UI
{
    partial class ProfileForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnChangePassword = new Button();
            btnTicket = new Button();
            btnChangeEmail = new Button();
            lblName = new Label();
            lblUsername = new Label();
            lblEmail = new Label();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            btnLogout = new Button();
            btnUserTickets = new Button();
            SuspendLayout();
            // 
            // btnChangePassword
            // 
            btnChangePassword.Location = new Point(247, 184);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new Size(171, 29);
            btnChangePassword.TabIndex = 0;
            btnChangePassword.Text = "Change Password";
            btnChangePassword.UseVisualStyleBackColor = true;
            btnChangePassword.Click += btnChangePassword_Click;
            // 
            // btnTicket
            // 
            btnTicket.Location = new Point(247, 293);
            btnTicket.Name = "btnTicket";
            btnTicket.Size = new Size(171, 29);
            btnTicket.TabIndex = 1;
            btnTicket.Text = "Go Ticket Shop";
            btnTicket.UseVisualStyleBackColor = true;
            btnTicket.Click += btnTicket_Click;
            // 
            // btnChangeEmail
            // 
            btnChangeEmail.Location = new Point(247, 237);
            btnChangeEmail.Name = "btnChangeEmail";
            btnChangeEmail.Size = new Size(171, 29);
            btnChangeEmail.TabIndex = 2;
            btnChangeEmail.Text = "Change email";
            btnChangeEmail.UseVisualStyleBackColor = true;
            btnChangeEmail.Click += btnChangeEmail_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(44, 22);
            lblName.Name = "lblName";
            lblName.Size = new Size(73, 20);
            lblName.TabIndex = 3;
            lblName.Text = "username";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(355, 22);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(73, 20);
            lblUsername.TabIndex = 3;
            lblUsername.Text = "username";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(676, 22);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(73, 20);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "username";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(44, 184);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(181, 27);
            txtPassword.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(44, 237);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(181, 27);
            txtEmail.TabIndex = 4;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(247, 337);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(171, 29);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Log out";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnUserTickets
            // 
            btnUserTickets.Location = new Point(455, 293);
            btnUserTickets.Name = "btnUserTickets";
            btnUserTickets.Size = new Size(140, 29);
            btnUserTickets.TabIndex = 6;
            btnUserTickets.Text = "My Tickets";
            btnUserTickets.UseVisualStyleBackColor = true;
            btnUserTickets.Click += btnUserTickets_Click;
            // 
            // ProfileForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnUserTickets);
            Controls.Add(btnLogout);
            Controls.Add(txtEmail);
            Controls.Add(txtPassword);
            Controls.Add(lblEmail);
            Controls.Add(lblUsername);
            Controls.Add(lblName);
            Controls.Add(btnChangeEmail);
            Controls.Add(btnTicket);
            Controls.Add(btnChangePassword);
            Name = "ProfileForm";
            Text = "ProfileForm";
            Load += ProfileForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnChangePassword;
        private Button btnTicket;
        private Button btnChangeEmail;
        private Label lblName;
        private Label lblUsername;
        private Label lblEmail;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private Button btnLogout;
        private Button btnUserTickets;
    }
}