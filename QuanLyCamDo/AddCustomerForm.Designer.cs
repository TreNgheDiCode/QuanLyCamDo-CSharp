namespace QuanLyCamDo
{
    partial class AddCustomerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCustomerForm));
            btnClose = new Button();
            btnContinue = new Button();
            btnSave = new Button();
            lbCustomerId = new Label();
            tbCustomerId = new TextBox();
            lbCustomerName = new Label();
            tbCustomerName = new TextBox();
            lbCustomerAddress = new Label();
            tbCustomerAddress = new TextBox();
            lbCMND = new Label();
            tbCMND = new TextBox();
            lbCreatedAt = new Label();
            dpCreatedAt = new DateTimePicker();
            lbProductType = new Label();
            lbProductName = new Label();
            tbProductName = new TextBox();
            lbWeight = new Label();
            lbPrice = new Label();
            lbFunds = new Label();
            numProductWeight = new NumericUpDown();
            label1 = new Label();
            numProductPrice = new NumericUpDown();
            label2 = new Label();
            numProductFund = new NumericUpDown();
            label3 = new Label();
            lbProductRate = new Label();
            numProductRate = new NumericUpDown();
            label4 = new Label();
            lbNote = new Label();
            tbNote = new TextBox();
            cbProductType = new ComboBox();
            btnAddProductType = new Button();
            tbAddCustomer = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            flowLayoutPanel3 = new FlowLayoutPanel();
            flowLayoutPanel4 = new FlowLayoutPanel();
            btnPrint = new Button();
            label5 = new Label();
            print = new System.Drawing.Printing.PrintDocument();
            listCustomers = new DataGridView();
            printDialog = new PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)numProductWeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numProductPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numProductFund).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numProductRate).BeginInit();
            tbAddCustomer.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)listCustomers).BeginInit();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.AutoSize = true;
            btnClose.BackColor = Color.White;
            btnClose.Font = new Font("Inter", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.Black;
            btnClose.Location = new Point(609, 268);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(140, 40);
            btnClose.TabIndex = 0;
            btnClose.Text = "Đóng (F5)";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnContinue
            // 
            btnContinue.AutoSize = true;
            btnContinue.BackColor = Color.White;
            btnContinue.Font = new Font("Inter", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnContinue.ForeColor = Color.Black;
            btnContinue.Location = new Point(457, 268);
            btnContinue.Name = "btnContinue";
            btnContinue.Size = new Size(140, 40);
            btnContinue.TabIndex = 1;
            btnContinue.Text = "Tiếp tục (F8)";
            btnContinue.UseVisualStyleBackColor = false;
            btnContinue.Click += btnContinue_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.White;
            btnSave.Font = new Font("Inter", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.Black;
            btnSave.Location = new Point(305, 268);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(140, 40);
            btnSave.TabIndex = 2;
            btnSave.Text = "Lưu (F2)";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += lbBtnSave_Click;
            btnSave.KeyDown += lbBtnSave_KeyDown;
            // 
            // lbCustomerId
            // 
            lbCustomerId.Anchor = AnchorStyles.Left;
            lbCustomerId.AutoSize = true;
            lbCustomerId.Font = new Font("Inter", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lbCustomerId.ForeColor = Color.Black;
            lbCustomerId.Location = new Point(3, 6);
            lbCustomerId.Name = "lbCustomerId";
            lbCustomerId.Size = new Size(130, 21);
            lbCustomerId.TabIndex = 0;
            lbCustomerId.Text = "Số biên nhận*";
            // 
            // tbCustomerId
            // 
            tbCustomerId.BackColor = Color.FromArgb(207, 243, 194);
            tbCustomerId.Enabled = false;
            tbCustomerId.Location = new Point(139, 3);
            tbCustomerId.Name = "tbCustomerId";
            tbCustomerId.Size = new Size(260, 27);
            tbCustomerId.TabIndex = 1;
            // 
            // lbCustomerName
            // 
            lbCustomerName.Anchor = AnchorStyles.Left;
            lbCustomerName.AutoSize = true;
            lbCustomerName.Font = new Font("Inter", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbCustomerName.ForeColor = Color.Black;
            lbCustomerName.Location = new Point(3, 42);
            lbCustomerName.Name = "lbCustomerName";
            lbCustomerName.Size = new Size(106, 21);
            lbCustomerName.TabIndex = 2;
            lbCustomerName.Text = "Họ tên KH*";
            lbCustomerName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbCustomerName
            // 
            tbCustomerName.Location = new Point(139, 36);
            tbCustomerName.Name = "tbCustomerName";
            tbCustomerName.Size = new Size(260, 27);
            tbCustomerName.TabIndex = 3;
            // 
            // lbCustomerAddress
            // 
            lbCustomerAddress.Anchor = AnchorStyles.Left;
            lbCustomerAddress.AutoSize = true;
            lbCustomerAddress.Font = new Font("Inter", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbCustomerAddress.ForeColor = Color.Black;
            lbCustomerAddress.Location = new Point(3, 81);
            lbCustomerAddress.Name = "lbCustomerAddress";
            lbCustomerAddress.Size = new Size(67, 21);
            lbCustomerAddress.TabIndex = 4;
            lbCustomerAddress.Text = "Địa chỉ";
            // 
            // tbCustomerAddress
            // 
            tbCustomerAddress.Location = new Point(139, 75);
            tbCustomerAddress.Name = "tbCustomerAddress";
            tbCustomerAddress.Size = new Size(260, 27);
            tbCustomerAddress.TabIndex = 5;
            // 
            // lbCMND
            // 
            lbCMND.Anchor = AnchorStyles.Left;
            lbCMND.AutoSize = true;
            lbCMND.Font = new Font("Inter", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbCMND.ForeColor = Color.Black;
            lbCMND.Location = new Point(3, 120);
            lbCMND.Name = "lbCMND";
            lbCMND.Size = new Size(62, 21);
            lbCMND.TabIndex = 6;
            lbCMND.Text = "CCCD";
            // 
            // tbCMND
            // 
            tbCMND.Location = new Point(139, 114);
            tbCMND.Name = "tbCMND";
            tbCMND.Size = new Size(260, 27);
            tbCMND.TabIndex = 7;
            // 
            // lbCreatedAt
            // 
            lbCreatedAt.Anchor = AnchorStyles.Left;
            lbCreatedAt.AutoSize = true;
            lbCreatedAt.BackColor = Color.Transparent;
            lbCreatedAt.Font = new Font("Inter", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbCreatedAt.ForeColor = Color.Black;
            lbCreatedAt.Location = new Point(3, 159);
            lbCreatedAt.Name = "lbCreatedAt";
            lbCreatedAt.Size = new Size(105, 21);
            lbCreatedAt.TabIndex = 8;
            lbCreatedAt.Text = "Ngày cầm*";
            // 
            // dpCreatedAt
            // 
            dpCreatedAt.Anchor = AnchorStyles.Left;
            dpCreatedAt.CalendarMonthBackground = Color.WhiteSmoke;
            dpCreatedAt.Enabled = false;
            dpCreatedAt.Location = new Point(139, 156);
            dpCreatedAt.Name = "dpCreatedAt";
            dpCreatedAt.Size = new Size(260, 27);
            dpCreatedAt.TabIndex = 9;
            // 
            // lbProductType
            // 
            lbProductType.Anchor = AnchorStyles.Left;
            lbProductType.AutoSize = true;
            lbProductType.Font = new Font("Inter", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbProductType.ForeColor = Color.Black;
            lbProductType.Location = new Point(3, 195);
            lbProductType.Name = "lbProductType";
            lbProductType.Size = new Size(115, 21);
            lbProductType.TabIndex = 10;
            lbProductType.Text = "Loại tài sản*";
            // 
            // lbProductName
            // 
            lbProductName.Anchor = AnchorStyles.Left;
            lbProductName.AutoSize = true;
            lbProductName.Font = new Font("Inter", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbProductName.ForeColor = Color.Black;
            lbProductName.Location = new Point(451, 6);
            lbProductName.Name = "lbProductName";
            lbProductName.Size = new Size(112, 21);
            lbProductName.TabIndex = 12;
            lbProductName.Text = "Tên tài sản*";
            // 
            // tbProductName
            // 
            tbProductName.Location = new Point(580, 3);
            tbProductName.Name = "tbProductName";
            tbProductName.Size = new Size(260, 27);
            tbProductName.TabIndex = 13;
            // 
            // lbWeight
            // 
            lbWeight.Anchor = AnchorStyles.Left;
            lbWeight.AutoSize = true;
            lbWeight.Font = new Font("Inter", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbWeight.ForeColor = Color.Black;
            lbWeight.Location = new Point(451, 42);
            lbWeight.Name = "lbWeight";
            lbWeight.Size = new Size(123, 21);
            lbWeight.TabIndex = 14;
            lbWeight.Text = "Trọng lượng*";
            // 
            // lbPrice
            // 
            lbPrice.Anchor = AnchorStyles.Left;
            lbPrice.AutoSize = true;
            lbPrice.Font = new Font("Inter", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbPrice.ForeColor = Color.Black;
            lbPrice.Location = new Point(451, 81);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(62, 21);
            lbPrice.TabIndex = 16;
            lbPrice.Text = "Trị giá";
            // 
            // lbFunds
            // 
            lbFunds.Anchor = AnchorStyles.Left;
            lbFunds.AutoSize = true;
            lbFunds.Font = new Font("Inter", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbFunds.ForeColor = Color.Black;
            lbFunds.Location = new Point(451, 120);
            lbFunds.Name = "lbFunds";
            lbFunds.Size = new Size(93, 21);
            lbFunds.TabIndex = 18;
            lbFunds.Text = "Tiền vốn*";
            // 
            // numProductWeight
            // 
            numProductWeight.Anchor = AnchorStyles.Left;
            numProductWeight.DecimalPlaces = 1;
            numProductWeight.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numProductWeight.Location = new Point(3, 3);
            numProductWeight.Name = "numProductWeight";
            numProductWeight.Size = new Size(257, 27);
            numProductWeight.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(266, 6);
            label1.Name = "label1";
            label1.Size = new Size(28, 20);
            label1.TabIndex = 1;
            label1.Text = "chỉ";
            // 
            // numProductPrice
            // 
            numProductPrice.Anchor = AnchorStyles.Left;
            numProductPrice.Increment = new decimal(new int[] { 100000, 0, 0, 0 });
            numProductPrice.Location = new Point(3, 3);
            numProductPrice.Maximum = new decimal(new int[] { 1410065408, 2, 0, 0 });
            numProductPrice.Name = "numProductPrice";
            numProductPrice.Size = new Size(257, 27);
            numProductPrice.TabIndex = 0;
            numProductPrice.ThousandsSeparator = true;
            numProductPrice.Value = new decimal(new int[] { 100000, 0, 0, 0 });
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(266, 6);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 1;
            label2.Text = "đồng";
            // 
            // numProductFund
            // 
            numProductFund.Anchor = AnchorStyles.Left;
            numProductFund.Increment = new decimal(new int[] { 100000, 0, 0, 0 });
            numProductFund.Location = new Point(3, 3);
            numProductFund.Maximum = new decimal(new int[] { 1410065408, 2, 0, 0 });
            numProductFund.Name = "numProductFund";
            numProductFund.Size = new Size(257, 27);
            numProductFund.TabIndex = 0;
            numProductFund.ThousandsSeparator = true;
            numProductFund.Value = new decimal(new int[] { 100000, 0, 0, 0 });
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(266, 6);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 1;
            label3.Text = "đồng";
            // 
            // lbProductRate
            // 
            lbProductRate.Anchor = AnchorStyles.Left;
            lbProductRate.AutoSize = true;
            lbProductRate.Font = new Font("Inter", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbProductRate.ForeColor = Color.Black;
            lbProductRate.Location = new Point(451, 159);
            lbProductRate.Name = "lbProductRate";
            lbProductRate.Size = new Size(84, 21);
            lbProductRate.TabIndex = 23;
            lbProductRate.Text = "Lãi suất*";
            // 
            // numProductRate
            // 
            numProductRate.DecimalPlaces = 1;
            numProductRate.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numProductRate.Location = new Point(3, 3);
            numProductRate.Name = "numProductRate";
            numProductRate.Size = new Size(257, 27);
            numProductRate.TabIndex = 0;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(266, 6);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 1;
            label4.Text = "%/tháng";
            // 
            // lbNote
            // 
            lbNote.Anchor = AnchorStyles.Left;
            lbNote.AutoSize = true;
            lbNote.Font = new Font("Inter", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbNote.ForeColor = Color.Black;
            lbNote.Location = new Point(451, 195);
            lbNote.Name = "lbNote";
            lbNote.Size = new Size(74, 21);
            lbNote.TabIndex = 25;
            lbNote.Text = "Ghi chú";
            // 
            // tbNote
            // 
            tbNote.Location = new Point(580, 192);
            tbNote.Name = "tbNote";
            tbNote.Size = new Size(260, 27);
            tbNote.TabIndex = 26;
            // 
            // cbProductType
            // 
            cbProductType.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbProductType.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbProductType.FormattingEnabled = true;
            cbProductType.Location = new Point(139, 192);
            cbProductType.Name = "cbProductType";
            cbProductType.Size = new Size(260, 28);
            cbProductType.TabIndex = 0;
            // 
            // btnAddProductType
            // 
            btnAddProductType.BackColor = Color.FromArgb(202, 223, 180);
            btnAddProductType.FlatStyle = FlatStyle.Flat;
            btnAddProductType.Font = new Font("Inter", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddProductType.ForeColor = Color.FromArgb(36, 0, 255);
            btnAddProductType.Location = new Point(405, 192);
            btnAddProductType.Name = "btnAddProductType";
            btnAddProductType.Size = new Size(40, 28);
            btnAddProductType.TabIndex = 1;
            btnAddProductType.Text = "+";
            btnAddProductType.UseVisualStyleBackColor = false;
            btnAddProductType.Click += btnAddProductType_Click;
            // 
            // tbAddCustomer
            // 
            tbAddCustomer.AutoSize = true;
            tbAddCustomer.ColumnCount = 5;
            tbAddCustomer.ColumnStyles.Add(new ColumnStyle());
            tbAddCustomer.ColumnStyles.Add(new ColumnStyle());
            tbAddCustomer.ColumnStyles.Add(new ColumnStyle());
            tbAddCustomer.ColumnStyles.Add(new ColumnStyle());
            tbAddCustomer.ColumnStyles.Add(new ColumnStyle());
            tbAddCustomer.Controls.Add(lbCustomerId, 0, 0);
            tbAddCustomer.Controls.Add(tbCustomerId, 1, 0);
            tbAddCustomer.Controls.Add(lbCustomerName, 0, 1);
            tbAddCustomer.Controls.Add(tbCustomerName, 1, 1);
            tbAddCustomer.Controls.Add(tbNote, 4, 5);
            tbAddCustomer.Controls.Add(lbNote, 3, 5);
            tbAddCustomer.Controls.Add(cbProductType, 1, 5);
            tbAddCustomer.Controls.Add(lbProductType, 0, 5);
            tbAddCustomer.Controls.Add(btnAddProductType, 2, 5);
            tbAddCustomer.Controls.Add(lbCustomerAddress, 0, 2);
            tbAddCustomer.Controls.Add(tbCustomerAddress, 1, 2);
            tbAddCustomer.Controls.Add(dpCreatedAt, 1, 4);
            tbAddCustomer.Controls.Add(lbCreatedAt, 0, 4);
            tbAddCustomer.Controls.Add(lbCMND, 0, 3);
            tbAddCustomer.Controls.Add(tbCMND, 1, 3);
            tbAddCustomer.Controls.Add(tbProductName, 4, 0);
            tbAddCustomer.Controls.Add(lbProductName, 3, 0);
            tbAddCustomer.Controls.Add(flowLayoutPanel1, 4, 1);
            tbAddCustomer.Controls.Add(lbWeight, 3, 1);
            tbAddCustomer.Controls.Add(flowLayoutPanel2, 4, 2);
            tbAddCustomer.Controls.Add(lbPrice, 3, 2);
            tbAddCustomer.Controls.Add(flowLayoutPanel3, 4, 3);
            tbAddCustomer.Controls.Add(lbFunds, 3, 3);
            tbAddCustomer.Controls.Add(flowLayoutPanel4, 4, 4);
            tbAddCustomer.Controls.Add(lbProductRate, 3, 4);
            tbAddCustomer.Location = new Point(0, 17);
            tbAddCustomer.Name = "tbAddCustomer";
            tbAddCustomer.RowCount = 6;
            tbAddCustomer.RowStyles.Add(new RowStyle());
            tbAddCustomer.RowStyles.Add(new RowStyle());
            tbAddCustomer.RowStyles.Add(new RowStyle());
            tbAddCustomer.RowStyles.Add(new RowStyle());
            tbAddCustomer.RowStyles.Add(new RowStyle());
            tbAddCustomer.RowStyles.Add(new RowStyle());
            tbAddCustomer.Size = new Size(917, 223);
            tbAddCustomer.TabIndex = 27;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(numProductWeight);
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Location = new Point(580, 36);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(297, 33);
            flowLayoutPanel1.TabIndex = 15;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.Controls.Add(numProductPrice);
            flowLayoutPanel2.Controls.Add(label2);
            flowLayoutPanel2.Location = new Point(580, 75);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(313, 33);
            flowLayoutPanel2.TabIndex = 17;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.AutoSize = true;
            flowLayoutPanel3.Controls.Add(numProductFund);
            flowLayoutPanel3.Controls.Add(label3);
            flowLayoutPanel3.Location = new Point(580, 114);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(313, 33);
            flowLayoutPanel3.TabIndex = 19;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.AutoSize = true;
            flowLayoutPanel4.Controls.Add(numProductRate);
            flowLayoutPanel4.Controls.Add(label4);
            flowLayoutPanel4.Location = new Point(580, 153);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(334, 33);
            flowLayoutPanel4.TabIndex = 24;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.White;
            btnPrint.Font = new Font("Inter", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrint.ForeColor = Color.Black;
            btnPrint.Location = new Point(153, 268);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(140, 40);
            btnPrint.TabIndex = 28;
            btnPrint.Text = "In BN (F3)";
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnPrint_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Inter", 14.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(0, 26, 255);
            label5.Location = new Point(12, 325);
            label5.Name = "label5";
            label5.Size = new Size(343, 30);
            label5.TabIndex = 29;
            label5.Text = "DANH SÁCH KHÁCH HÀNG";
            // 
            // print
            // 
            print.BeginPrint += print_BeginPrint;
            print.PrintPage += print_PrintPage;
            // 
            // listCustomers
            // 
            listCustomers.AllowUserToDeleteRows = false;
            listCustomers.AllowUserToOrderColumns = true;
            listCustomers.BackgroundColor = Color.White;
            listCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listCustomers.Location = new Point(12, 358);
            listCustomers.Name = "listCustomers";
            listCustomers.ReadOnly = true;
            listCustomers.RowHeadersWidth = 51;
            listCustomers.Size = new Size(897, 392);
            listCustomers.TabIndex = 30;
            // 
            // printDialog
            // 
            printDialog.AutoScrollMargin = new Size(0, 0);
            printDialog.AutoScrollMinSize = new Size(0, 0);
            printDialog.ClientSize = new Size(400, 300);
            printDialog.Document = print;
            printDialog.Enabled = true;
            printDialog.Icon = (Icon)resources.GetObject("printDialog.Icon");
            printDialog.Name = "printDialog";
            printDialog.Visible = false;
            // 
            // AddCustomerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(141, 200, 94);
            ClientSize = new Size(921, 762);
            Controls.Add(listCustomers);
            Controls.Add(label5);
            Controls.Add(btnPrint);
            Controls.Add(tbAddCustomer);
            Controls.Add(btnClose);
            Controls.Add(btnContinue);
            Controls.Add(btnSave);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AddCustomerForm";
            Text = "Nhập thêm khách hàng";
            ((System.ComponentModel.ISupportInitialize)numProductWeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)numProductPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numProductFund).EndInit();
            ((System.ComponentModel.ISupportInitialize)numProductRate).EndInit();
            tbAddCustomer.ResumeLayout(false);
            tbAddCustomer.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)listCustomers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbCustomerId;
        private TextBox tbCustomerId;
        private Label lbCustomerName;
        private TextBox tbCustomerName;
        private Button btnClose;
        private Button btnContinue;
        private Button btnSave;
        private Label lbCustomerAddress;
        private TextBox tbCustomerAddress;
        private Label lbCMND;
        private TextBox tbCMND;
        private Label lbCreatedAt;
        private DateTimePicker dpCreatedAt;
        private Label lbProductType;
        private Label lbProductName;
        private TextBox tbProductName;
        private Label lbWeight;
        private Label lbPrice;
        private Label lbFunds;
        private NumericUpDown numProductWeight;
        private Label label1;
        private NumericUpDown numProductPrice;
        private Label label2;
        private NumericUpDown numProductFund;
        private Label label3;
        private Label lbProductRate;
        private FlowLayoutPanel flowLayoutPanel4;
        private NumericUpDown numProductRate;
        private Label label4;
        private Label lbNote;
        private TextBox tbNote;
        private ComboBox cbProductType;
        private Button btnAddProductType;
        private TableLayoutPanel tbAddCustomer;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel3;
        private Button btnPrint;
        private Label label5;
        private System.Drawing.Printing.PrintDocument print;
        private DataGridView listCustomers;
        private PrintPreviewDialog printDialog;
    }
}