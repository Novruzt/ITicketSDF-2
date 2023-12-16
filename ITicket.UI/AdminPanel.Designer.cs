namespace ITicket.UI
{
    partial class AdminPanel
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
            dgwEvents = new DataGridView();
            btnDelete = new Button();
            btnUpdate = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgwEvents).BeginInit();
            SuspendLayout();
            // 
            // dgwEvents
            // 
            dgwEvents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwEvents.Location = new Point(419, 12);
            dgwEvents.Name = "dgwEvents";
            dgwEvents.RowHeadersWidth = 51;
            dgwEvents.Size = new Size(369, 426);
            dgwEvents.TabIndex = 0;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(41, 139);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(41, 174);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(41, 209);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 1;
            button3.Text = "btnCreate";
            button3.UseVisualStyleBackColor = true;
            // 
            // AdminPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(dgwEvents);
            Name = "AdminPanel";
            Text = "AdminPanel";
            ((System.ComponentModel.ISupportInitialize)dgwEvents).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgwEvents;
        private Button btnDelete;
        private Button btnUpdate;
        private Button button3;
    }
}