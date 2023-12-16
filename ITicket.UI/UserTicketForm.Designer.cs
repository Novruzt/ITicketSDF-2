namespace ITicket.UI
{
    partial class UserTicketForm
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
            dgwTicket = new DataGridView();
            txtTicketName = new TextBox();
            label2 = new Label();
            comboPrice = new ComboBox();
            txtPrice = new TextBox();
            Price = new Label();
            label1 = new Label();
            btnBack = new Button();
            btnSearch = new Button();
            comboTicketType = new ComboBox();
            label3 = new Label();
            comboDate = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgwTicket).BeginInit();
            SuspendLayout();
            // 
            // dgwTicket
            // 
            dgwTicket.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwTicket.Location = new Point(422, 12);
            dgwTicket.Name = "dgwTicket";
            dgwTicket.RowHeadersWidth = 51;
            dgwTicket.Size = new Size(366, 417);
            dgwTicket.TabIndex = 0;
            // 
            // txtTicketName
            // 
            txtTicketName.Location = new Point(121, 74);
            txtTicketName.Name = "txtTicketName";
            txtTicketName.Size = new Size(220, 27);
            txtTicketName.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 77);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 19;
            label2.Text = "Name";
            // 
            // comboPrice
            // 
            comboPrice.FormattingEnabled = true;
            comboPrice.Location = new Point(215, 178);
            comboPrice.Name = "comboPrice";
            comboPrice.Size = new Size(126, 28);
            comboPrice.TabIndex = 18;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(121, 179);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(78, 27);
            txtPrice.TabIndex = 16;
            // 
            // Price
            // 
            Price.AutoSize = true;
            Price.Location = new Point(27, 186);
            Price.Name = "Price";
            Price.Size = new Size(41, 20);
            Price.TabIndex = 14;
            Price.Text = "Price";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 124);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 15;
            label1.Text = "Ticket Type";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(12, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 10;
            btnBack.Text = "<<<";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(163, 275);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 11;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // comboTicketType
            // 
            comboTicketType.FormattingEnabled = true;
            comboTicketType.Location = new Point(121, 121);
            comboTicketType.Name = "comboTicketType";
            comboTicketType.Size = new Size(220, 28);
            comboTicketType.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 238);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 14;
            label3.Text = "Date";
            // 
            // comboDate
            // 
            comboDate.FormattingEnabled = true;
            comboDate.Location = new Point(121, 235);
            comboDate.Name = "comboDate";
            comboDate.Size = new Size(220, 28);
            comboDate.TabIndex = 18;
            // 
            // UserTicketForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtTicketName);
            Controls.Add(label2);
            Controls.Add(comboDate);
            Controls.Add(comboPrice);
            Controls.Add(txtPrice);
            Controls.Add(label3);
            Controls.Add(Price);
            Controls.Add(label1);
            Controls.Add(btnBack);
            Controls.Add(btnSearch);
            Controls.Add(comboTicketType);
            Controls.Add(dgwTicket);
            Name = "UserTicketForm";
            Text = "UserTicketForm";
            Load += UserTicketForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgwTicket).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgwTicket;
        private TextBox txtTicketName;
        private Label label2;
        private ComboBox comboPrice;
        private TextBox txtPrice;
        private Label Price;
        private Label label1;
        private Button btnBack;
        private Button btnSearch;
        private ComboBox comboTicketType;
        private Label label3;
        private ComboBox comboDate;
    }
}