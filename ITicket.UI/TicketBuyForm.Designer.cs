namespace ITicket.UI
{
    partial class TicketBuyForm
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
            comboTicketType = new ComboBox();
            btnBuyTicket = new Button();
            label1 = new Label();
            txtPrice = new TextBox();
            Price = new Label();
            comboPrice = new ComboBox();
            Count = new Label();
            comboNumber = new ComboBox();
            btnBack = new Button();
            btnSearch = new Button();
            dgwTicket = new DataGridView();
            label2 = new Label();
            txtTicketName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgwTicket).BeginInit();
            SuspendLayout();
            // 
            // comboTicketType
            // 
            comboTicketType.FormattingEnabled = true;
            comboTicketType.Location = new Point(121, 121);
            comboTicketType.Name = "comboTicketType";
            comboTicketType.Size = new Size(220, 28);
            comboTicketType.TabIndex = 1;
            comboTicketType.SelectedIndexChanged += comboTicketType_SelectedIndexChanged;
            // 
            // btnBuyTicket
            // 
            btnBuyTicket.Location = new Point(146, 390);
            btnBuyTicket.Name = "btnBuyTicket";
            btnBuyTicket.Size = new Size(94, 29);
            btnBuyTicket.TabIndex = 2;
            btnBuyTicket.Text = "Buy Ticket";
            btnBuyTicket.UseVisualStyleBackColor = true;
            btnBuyTicket.Click += btnBuyTicket_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 124);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 3;
            label1.Text = "Ticket Type";
           
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(121, 179);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(78, 27);
            txtPrice.TabIndex = 4;
            
            // 
            // Price
            // 
            Price.AutoSize = true;
            Price.Location = new Point(27, 186);
            Price.Name = "Price";
            Price.Size = new Size(41, 20);
            Price.TabIndex = 3;
            Price.Text = "Price";
     
            // 
            // comboPrice
            // 
            comboPrice.FormattingEnabled = true;
            comboPrice.Location = new Point(215, 178);
            comboPrice.Name = "comboPrice";
            comboPrice.Size = new Size(126, 28);
            comboPrice.TabIndex = 5;
           
            // 
            // Count
            // 
            Count.AutoSize = true;
            Count.Location = new Point(27, 264);
            Count.Name = "Count";
            Count.Size = new Size(63, 20);
            Count.TabIndex = 3;
            Count.Text = "Number";
       
            // 
            // comboNumber
            // 
            comboNumber.FormattingEnabled = true;
            comboNumber.Location = new Point(121, 256);
            comboNumber.Name = "comboNumber";
            comboNumber.Size = new Size(99, 28);
            comboNumber.TabIndex = 5;
           
            // 
            // btnBack
            // 
            btnBack.Location = new Point(12, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 2;
            btnBack.Text = "<<<";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(146, 308);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // dgwTicket
            // 
            dgwTicket.AllowUserToAddRows = false;
            dgwTicket.AllowUserToDeleteRows = false;
            dgwTicket.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwTicket.Location = new Point(400, 37);
            dgwTicket.Name = "dgwTicket";
            dgwTicket.ReadOnly = true;
            dgwTicket.RowHeadersWidth = 51;
            dgwTicket.Size = new Size(388, 382);
            dgwTicket.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 77);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 7;
            label2.Text = "Name";
            // 
            // txtTicketName
            // 
            txtTicketName.Location = new Point(121, 74);
            txtTicketName.Name = "txtTicketName";
            txtTicketName.Size = new Size(220, 27);
            txtTicketName.TabIndex = 8;
         
            // 
            // TicketBuyForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtTicketName);
            Controls.Add(label2);
            Controls.Add(dgwTicket);
            Controls.Add(comboNumber);
            Controls.Add(comboPrice);
            Controls.Add(txtPrice);
            Controls.Add(Count);
            Controls.Add(Price);
            Controls.Add(label1);
            Controls.Add(btnBack);
            Controls.Add(btnSearch);
            Controls.Add(btnBuyTicket);
            Controls.Add(comboTicketType);
            Name = "TicketBuyForm";
            Text = "TicketBuyForm";
            Load += TicketBuyForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgwTicket).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox comboTicketType;
        private Button btnBuyTicket;
        private Label label1;
        private TextBox txtPrice;
        private Label Price;
        private ComboBox comboPrice;
        private Label Count;
        private ComboBox comboNumber;
        private Button btnBack;
        private Button btnSearch;
        private DataGridView dgwTicket;
        private Label label2;
        private TextBox txtTicketName;
    }
}