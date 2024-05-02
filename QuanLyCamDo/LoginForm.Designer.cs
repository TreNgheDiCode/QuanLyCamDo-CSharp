namespace QuanLyCamDo
{
    partial class LoginForm
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
            tbUsername = new TextBox();
            label2 = new Label();
            tbPassword = new TextBox();
            btnContinue = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Inter", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(137, 21);
            label1.TabIndex = 0;
            label1.Text = "Tên đăng nhập";
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(155, 7);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(283, 27);
            tbUsername.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Inter", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(12, 42);
            label2.Name = "label2";
            label2.Size = new Size(89, 21);
            label2.TabIndex = 2;
            label2.Text = "Mật khẩu";
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(155, 40);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(283, 27);
            tbPassword.TabIndex = 3;
            tbPassword.TextChanged += tbPassword_TextChanged;
            // 
            // btnContinue
            // 
            btnContinue.AutoSize = true;
            btnContinue.BackColor = Color.White;
            btnContinue.Font = new Font("Inter", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnContinue.ForeColor = Color.Black;
            btnContinue.Location = new Point(140, 84);
            btnContinue.Name = "btnContinue";
            btnContinue.Size = new Size(152, 40);
            btnContinue.TabIndex = 6;
            btnContinue.Text = "Đăng nhập (F2)";
            btnContinue.UseVisualStyleBackColor = false;
            btnContinue.Click += btnContinue_Click;
            // 
            // btnClose
            // 
            btnClose.AutoSize = true;
            btnClose.BackColor = Color.White;
            btnClose.Font = new Font("Inter", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.Black;
            btnClose.Location = new Point(298, 84);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(140, 40);
            btnClose.TabIndex = 5;
            btnClose.Text = "Đóng (F5)";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(247, 255, 241);
            ClientSize = new Size(800, 450);
            Controls.Add(btnContinue);
            Controls.Add(btnClose);
            Controls.Add(tbPassword);
            Controls.Add(label2);
            Controls.Add(tbUsername);
            Controls.Add(label1);
            Name = "LoginForm";
            Text = "Đăng nhập";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbUsername;
        private Label label2;
        private TextBox tbPassword;
        private Button btnContinue;
        private Button btnClose;
    }
}