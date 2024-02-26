namespace QuanLyCamDo
{
    partial class SearchCustomerByIdForm
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
            label1 = new Label();
            tbCustomerId = new TextBox();
            btnContinue = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Inter", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(169, 21);
            label1.TabIndex = 0;
            label1.Text = "Nhập số biên nhận";
            // 
            // tbCustomerId
            // 
            tbCustomerId.Location = new Point(187, 12);
            tbCustomerId.Name = "tbCustomerId";
            tbCustomerId.Size = new Size(246, 27);
            tbCustomerId.TabIndex = 1;
            // 
            // btnContinue
            // 
            btnContinue.BackColor = Color.White;
            btnContinue.Font = new Font("Inter", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnContinue.ForeColor = Color.Black;
            btnContinue.Location = new Point(147, 59);
            btnContinue.Name = "btnContinue";
            btnContinue.Size = new Size(140, 40);
            btnContinue.TabIndex = 2;
            btnContinue.Text = "Tiếp tục (F8)";
            btnContinue.UseVisualStyleBackColor = false;
            btnContinue.Click += btnContinue_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.White;
            btnClose.Font = new Font("Inter", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.Black;
            btnClose.Location = new Point(293, 59);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(140, 40);
            btnClose.TabIndex = 3;
            btnClose.Text = "Đóng (F5)";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // SearchCustomerByIdForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(445, 110);
            Controls.Add(btnClose);
            Controls.Add(btnContinue);
            Controls.Add(tbCustomerId);
            Controls.Add(label1);
            Name = "SearchCustomerByIdForm";
            Text = "Số biên nhận";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbCustomerId;
        private Button btnContinue;
        private Button btnClose;
    }
}