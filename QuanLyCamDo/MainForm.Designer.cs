namespace QuanLyCamDo
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            lbSubCompany = new Label();
            lbCompanyName = new Label();
            lbApp = new Label();
            lbTitle = new Label();
            btnAddCustomer = new Button();
            lbCurrentTime = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            btnExtendCustomer = new Button();
            btnRedeemCustomer = new Button();
            btnSearchCustomer = new Button();
            btnLiquidation = new Button();
            btnStatistic = new Button();
            btnAudit = new Button();
            btnClose = new Button();
            btnSetting = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbSubCompany
            // 
            lbSubCompany.Anchor = AnchorStyles.Top;
            lbSubCompany.AutoSize = true;
            lbSubCompany.BackColor = Color.Transparent;
            lbSubCompany.Font = new Font("Inter", 14.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbSubCompany.ForeColor = Color.Black;
            lbSubCompany.Location = new Point(345, 23);
            lbSubCompany.Name = "lbSubCompany";
            lbSubCompany.Size = new Size(230, 30);
            lbSubCompany.TabIndex = 0;
            lbSubCompany.Text = "DỊCH VỤ CẦM ĐỒ";
            lbSubCompany.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbCompanyName
            // 
            lbCompanyName.Anchor = AnchorStyles.Top;
            lbCompanyName.AutoSize = true;
            lbCompanyName.BackColor = Color.Transparent;
            lbCompanyName.Font = new Font("Inter", 22.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbCompanyName.ForeColor = Color.Red;
            lbCompanyName.Location = new Point(349, 58);
            lbCompanyName.Name = "lbCompanyName";
            lbCompanyName.Size = new Size(316, 47);
            lbCompanyName.TabIndex = 1;
            lbCompanyName.Text = "PHƯƠNG TRÚC";
            lbCompanyName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbApp
            // 
            lbApp.Anchor = AnchorStyles.Top;
            lbApp.AutoSize = true;
            lbApp.BackColor = Color.Transparent;
            lbApp.Font = new Font("Inter", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbApp.ForeColor = Color.Black;
            lbApp.Location = new Point(421, 142);
            lbApp.Name = "lbApp";
            lbApp.Size = new Size(108, 21);
            lbApp.TabIndex = 2;
            lbApp.Text = "PHẦN MỀM";
            // 
            // lbTitle
            // 
            lbTitle.Anchor = AnchorStyles.Top;
            lbTitle.AutoSize = true;
            lbTitle.BackColor = Color.Transparent;
            lbTitle.Font = new Font("Inter ExtraBold", 22.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTitle.ForeColor = Color.Red;
            lbTitle.Location = new Point(313, 171);
            lbTitle.Margin = new Padding(0);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(362, 47);
            lbTitle.TabIndex = 3;
            lbTitle.Text = "QUẢN LÝ CẦM ĐỒ";
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.BackColor = Color.White;
            btnAddCustomer.Font = new Font("Inter", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddCustomer.Location = new Point(44, 291);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(180, 50);
            btnAddCustomer.TabIndex = 4;
            btnAddCustomer.Text = "Thêm khách hàng";
            btnAddCustomer.UseVisualStyleBackColor = false;
            btnAddCustomer.Click += lbAddCustomer_Click;
            // 
            // lbCurrentTime
            // 
            lbCurrentTime.Anchor = AnchorStyles.Top;
            lbCurrentTime.BackColor = Color.White;
            lbCurrentTime.Font = new Font("Inter", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbCurrentTime.ForeColor = Color.Black;
            lbCurrentTime.Location = new Point(-9, 228);
            lbCurrentTime.Name = "lbCurrentTime";
            lbCurrentTime.Size = new Size(878, 37);
            lbCurrentTime.TabIndex = 5;
            lbCurrentTime.Text = "Current time";
            lbCurrentTime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // btnExtendCustomer
            // 
            btnExtendCustomer.BackColor = Color.White;
            btnExtendCustomer.Font = new Font("Inter", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExtendCustomer.Location = new Point(242, 291);
            btnExtendCustomer.Name = "btnExtendCustomer";
            btnExtendCustomer.Size = new Size(180, 50);
            btnExtendCustomer.TabIndex = 6;
            btnExtendCustomer.Text = "Khách hàng gia hạn";
            btnExtendCustomer.UseVisualStyleBackColor = false;
            btnExtendCustomer.Click += btnExtendCustomer_Click;
            // 
            // btnRedeemCustomer
            // 
            btnRedeemCustomer.BackColor = Color.White;
            btnRedeemCustomer.Font = new Font("Inter", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRedeemCustomer.Location = new Point(440, 291);
            btnRedeemCustomer.Name = "btnRedeemCustomer";
            btnRedeemCustomer.Size = new Size(180, 50);
            btnRedeemCustomer.TabIndex = 7;
            btnRedeemCustomer.Text = "Khách hàng chuộc đồ";
            btnRedeemCustomer.UseVisualStyleBackColor = false;
            btnRedeemCustomer.Click += btnRedeemCustomer_Click;
            // 
            // btnSearchCustomer
            // 
            btnSearchCustomer.BackColor = Color.White;
            btnSearchCustomer.Font = new Font("Inter", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearchCustomer.Location = new Point(638, 291);
            btnSearchCustomer.Name = "btnSearchCustomer";
            btnSearchCustomer.Size = new Size(180, 50);
            btnSearchCustomer.TabIndex = 8;
            btnSearchCustomer.Text = "Tìm kiếm khách hàng";
            btnSearchCustomer.UseVisualStyleBackColor = false;
            btnSearchCustomer.Click += btnSearchCustomer_Click;
            // 
            // btnLiquidation
            // 
            btnLiquidation.BackColor = Color.White;
            btnLiquidation.Font = new Font("Inter", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLiquidation.Location = new Point(44, 363);
            btnLiquidation.Name = "btnLiquidation";
            btnLiquidation.Size = new Size(180, 50);
            btnLiquidation.TabIndex = 9;
            btnLiquidation.Text = "Dự báo thanh lý";
            btnLiquidation.UseVisualStyleBackColor = false;
            // 
            // btnStatistic
            // 
            btnStatistic.BackColor = Color.White;
            btnStatistic.Font = new Font("Inter", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnStatistic.Location = new Point(244, 363);
            btnStatistic.Name = "btnStatistic";
            btnStatistic.Size = new Size(180, 50);
            btnStatistic.TabIndex = 10;
            btnStatistic.Text = "Thống kê";
            btnStatistic.UseVisualStyleBackColor = false;
            // 
            // btnAudit
            // 
            btnAudit.BackColor = Color.White;
            btnAudit.Font = new Font("Inter", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAudit.Location = new Point(444, 363);
            btnAudit.Name = "btnAudit";
            btnAudit.Size = new Size(180, 50);
            btnAudit.TabIndex = 11;
            btnAudit.Text = "Kiểm toán";
            btnAudit.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.White;
            btnClose.BackgroundImage = (Image)resources.GetObject("btnClose.BackgroundImage");
            btnClose.Font = new Font("Inter", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(44, 429);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(40, 40);
            btnClose.TabIndex = 14;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnSetting
            // 
            btnSetting.BackColor = Color.FromArgb(214, 230, 193);
            btnSetting.Font = new Font("Inter Medium", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSetting.Location = new Point(707, 12);
            btnSetting.Name = "btnSetting";
            btnSetting.Size = new Size(140, 40);
            btnSetting.TabIndex = 15;
            btnSetting.Text = "Cài đặt";
            btnSetting.UseVisualStyleBackColor = false;
            btnSetting.Click += btnSetting_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(20, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(124, 107);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(217, 255, 187);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(859, 481);
            Controls.Add(pictureBox1);
            Controls.Add(btnSetting);
            Controls.Add(btnClose);
            Controls.Add(btnAudit);
            Controls.Add(btnStatistic);
            Controls.Add(btnLiquidation);
            Controls.Add(btnSearchCustomer);
            Controls.Add(btnRedeemCustomer);
            Controls.Add(btnExtendCustomer);
            Controls.Add(lbSubCompany);
            Controls.Add(lbCompanyName);
            Controls.Add(lbApp);
            Controls.Add(btnAddCustomer);
            Controls.Add(lbTitle);
            Controls.Add(lbCurrentTime);
            Name = "MainForm";
            Text = "Quản lí cầm đồ";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbSubCompany;
        private Label lbCompanyName;
        private Label lbApp;
        private Label lbTitle;
        private Button btnAddCustomer;
        private Label lbCurrentTime;
        private System.Windows.Forms.Timer timer1;
        private Button btnExtendCustomer;
        private Button btnRedeemCustomer;
        private Button btnSearchCustomer;
        private Button btnLiquidation;
        private Button btnStatistic;
        private Button btnAudit;
        private Button btnClose;
        private Button btnSetting;
        private PictureBox pictureBox1;
    }
}
