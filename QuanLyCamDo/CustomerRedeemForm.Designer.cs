namespace QuanLyCamDo
{
    partial class CustomerRedeemForm
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
            tbAddCustomer = new TableLayoutPanel();
            lbCustomerId = new Label();
            tbCustomerId = new TextBox();
            lbCustomerName = new Label();
            tbCustomerName = new TextBox();
            tbNote = new TextBox();
            lbNote = new Label();
            cbProductType = new ComboBox();
            lbProductType = new Label();
            lbCustomerAddress = new Label();
            tbCustomerAddress = new TextBox();
            dpCreatedAt = new DateTimePicker();
            lbCreatedAt = new Label();
            lbCMND = new Label();
            tbCMND = new TextBox();
            tbProductName = new TextBox();
            lbProductName = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            numProductWeight = new NumericUpDown();
            label1 = new Label();
            lbWeight = new Label();
            lbPrice = new Label();
            lbFunds = new Label();
            flowLayoutPanel4 = new FlowLayoutPanel();
            numProductRate = new NumericUpDown();
            label4 = new Label();
            lbProductRate = new Label();
            flowLayoutPanel3 = new FlowLayoutPanel();
            numProductFund = new NumericUpDown();
            label3 = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            numProductPrice = new NumericUpDown();
            label2 = new Label();
            label5 = new Label();
            dpRedeemDate = new DateTimePicker();
            label6 = new Label();
            flowLayoutPanel5 = new FlowLayoutPanel();
            numRedeemPrice = new NumericUpDown();
            label7 = new Label();
            flowLayoutPanel6 = new FlowLayoutPanel();
            numRedeemTotal = new NumericUpDown();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            tbCustomerStatus = new TextBox();
            label11 = new Label();
            tbRedeemNote = new TextBox();
            btnPrint = new Button();
            btnClose = new Button();
            btnSave = new Button();
            tbAddCustomer.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numProductWeight).BeginInit();
            flowLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numProductRate).BeginInit();
            flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numProductFund).BeginInit();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numProductPrice).BeginInit();
            flowLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numRedeemPrice).BeginInit();
            flowLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numRedeemTotal).BeginInit();
            SuspendLayout();
            // 
            // tbAddCustomer
            // 
            tbAddCustomer.AutoSize = true;
            tbAddCustomer.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tbAddCustomer.ColumnCount = 5;
            tbAddCustomer.ColumnStyles.Add(new ColumnStyle());
            tbAddCustomer.ColumnStyles.Add(new ColumnStyle());
            tbAddCustomer.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30F));
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
            tbAddCustomer.Controls.Add(lbPrice, 3, 2);
            tbAddCustomer.Controls.Add(lbFunds, 3, 3);
            tbAddCustomer.Controls.Add(flowLayoutPanel4, 4, 4);
            tbAddCustomer.Controls.Add(lbProductRate, 3, 4);
            tbAddCustomer.Controls.Add(flowLayoutPanel3, 4, 3);
            tbAddCustomer.Controls.Add(flowLayoutPanel2, 4, 2);
            tbAddCustomer.Location = new Point(4, 12);
            tbAddCustomer.Name = "tbAddCustomer";
            tbAddCustomer.RowCount = 6;
            tbAddCustomer.RowStyles.Add(new RowStyle());
            tbAddCustomer.RowStyles.Add(new RowStyle());
            tbAddCustomer.RowStyles.Add(new RowStyle());
            tbAddCustomer.RowStyles.Add(new RowStyle());
            tbAddCustomer.RowStyles.Add(new RowStyle());
            tbAddCustomer.RowStyles.Add(new RowStyle());
            tbAddCustomer.Size = new Size(901, 223);
            tbAddCustomer.TabIndex = 29;
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
            // tbNote
            // 
            tbNote.Location = new Point(564, 192);
            tbNote.Name = "tbNote";
            tbNote.Size = new Size(260, 27);
            tbNote.TabIndex = 26;
            // 
            // lbNote
            // 
            lbNote.Anchor = AnchorStyles.Left;
            lbNote.AutoSize = true;
            lbNote.Font = new Font("Inter", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbNote.ForeColor = Color.Black;
            lbNote.Location = new Point(435, 195);
            lbNote.Name = "lbNote";
            lbNote.Size = new Size(74, 21);
            lbNote.TabIndex = 25;
            lbNote.Text = "Ghi chú";
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
            // lbCustomerAddress
            // 
            lbCustomerAddress.Anchor = AnchorStyles.Left;
            lbCustomerAddress.AutoSize = true;
            lbCustomerAddress.Font = new Font("Inter", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbCustomerAddress.ForeColor = Color.Black;
            lbCustomerAddress.Location = new Point(3, 81);
            lbCustomerAddress.Name = "lbCustomerAddress";
            lbCustomerAddress.Size = new Size(76, 21);
            lbCustomerAddress.TabIndex = 4;
            lbCustomerAddress.Text = "Địa chỉ*";
            // 
            // tbCustomerAddress
            // 
            tbCustomerAddress.Location = new Point(139, 75);
            tbCustomerAddress.Name = "tbCustomerAddress";
            tbCustomerAddress.Size = new Size(260, 27);
            tbCustomerAddress.TabIndex = 5;
            // 
            // dpCreatedAt
            // 
            dpCreatedAt.Anchor = AnchorStyles.Left;
            dpCreatedAt.Location = new Point(139, 156);
            dpCreatedAt.Name = "dpCreatedAt";
            dpCreatedAt.Size = new Size(260, 27);
            dpCreatedAt.TabIndex = 9;
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
            // tbProductName
            // 
            tbProductName.Location = new Point(564, 3);
            tbProductName.Name = "tbProductName";
            tbProductName.Size = new Size(260, 27);
            tbProductName.TabIndex = 13;
            // 
            // lbProductName
            // 
            lbProductName.Anchor = AnchorStyles.Left;
            lbProductName.AutoSize = true;
            lbProductName.Font = new Font("Inter", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbProductName.ForeColor = Color.Black;
            lbProductName.Location = new Point(435, 6);
            lbProductName.Name = "lbProductName";
            lbProductName.Size = new Size(112, 21);
            lbProductName.TabIndex = 12;
            lbProductName.Text = "Tên tài sản*";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(numProductWeight);
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Location = new Point(564, 36);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(297, 33);
            flowLayoutPanel1.TabIndex = 15;
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
            // lbWeight
            // 
            lbWeight.Anchor = AnchorStyles.Left;
            lbWeight.AutoSize = true;
            lbWeight.Font = new Font("Inter", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbWeight.ForeColor = Color.Black;
            lbWeight.Location = new Point(435, 42);
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
            lbPrice.Location = new Point(435, 81);
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
            lbFunds.Location = new Point(435, 120);
            lbFunds.Name = "lbFunds";
            lbFunds.Size = new Size(93, 21);
            lbFunds.TabIndex = 18;
            lbFunds.Text = "Tiền vốn*";
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.AutoSize = true;
            flowLayoutPanel4.Controls.Add(numProductRate);
            flowLayoutPanel4.Controls.Add(label4);
            flowLayoutPanel4.Location = new Point(564, 153);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(334, 33);
            flowLayoutPanel4.TabIndex = 24;
            // 
            // numProductRate
            // 
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
            // lbProductRate
            // 
            lbProductRate.Anchor = AnchorStyles.Left;
            lbProductRate.AutoSize = true;
            lbProductRate.Font = new Font("Inter", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbProductRate.ForeColor = Color.Black;
            lbProductRate.Location = new Point(435, 159);
            lbProductRate.Name = "lbProductRate";
            lbProductRate.Size = new Size(84, 21);
            lbProductRate.TabIndex = 23;
            lbProductRate.Text = "Lãi suất*";
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.AutoSize = true;
            flowLayoutPanel3.Controls.Add(numProductFund);
            flowLayoutPanel3.Controls.Add(label3);
            flowLayoutPanel3.Location = new Point(564, 114);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(313, 33);
            flowLayoutPanel3.TabIndex = 19;
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
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.Controls.Add(numProductPrice);
            flowLayoutPanel2.Controls.Add(label2);
            flowLayoutPanel2.Location = new Point(564, 75);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(313, 33);
            flowLayoutPanel2.TabIndex = 17;
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
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Inter", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(4, 287);
            label5.Name = "label5";
            label5.Size = new Size(121, 21);
            label5.TabIndex = 27;
            label5.Text = "Ngày chuộc*";
            // 
            // dpRedeemDate
            // 
            dpRedeemDate.Anchor = AnchorStyles.Left;
            dpRedeemDate.Location = new Point(167, 287);
            dpRedeemDate.Name = "dpRedeemDate";
            dpRedeemDate.Size = new Size(260, 27);
            dpRedeemDate.TabIndex = 27;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Inter", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(4, 326);
            label6.Name = "label6";
            label6.Size = new Size(113, 21);
            label6.TabIndex = 27;
            label6.Text = "Tiền chuộc*";
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.AutoSize = true;
            flowLayoutPanel5.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel5.Controls.Add(numRedeemPrice);
            flowLayoutPanel5.Controls.Add(label7);
            flowLayoutPanel5.Location = new Point(167, 320);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Size = new Size(313, 33);
            flowLayoutPanel5.TabIndex = 30;
            // 
            // numRedeemPrice
            // 
            numRedeemPrice.Anchor = AnchorStyles.Left;
            numRedeemPrice.Increment = new decimal(new int[] { 100000, 0, 0, 0 });
            numRedeemPrice.Location = new Point(3, 3);
            numRedeemPrice.Maximum = new decimal(new int[] { 1410065408, 2, 0, 0 });
            numRedeemPrice.Name = "numRedeemPrice";
            numRedeemPrice.Size = new Size(257, 27);
            numRedeemPrice.TabIndex = 0;
            numRedeemPrice.ThousandsSeparator = true;
            numRedeemPrice.Value = new decimal(new int[] { 100000, 0, 0, 0 });
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Location = new Point(266, 6);
            label7.Name = "label7";
            label7.Size = new Size(44, 20);
            label7.TabIndex = 1;
            label7.Text = "đồng";
            // 
            // flowLayoutPanel6
            // 
            flowLayoutPanel6.AutoSize = true;
            flowLayoutPanel6.Controls.Add(numRedeemTotal);
            flowLayoutPanel6.Controls.Add(label8);
            flowLayoutPanel6.Location = new Point(167, 359);
            flowLayoutPanel6.Name = "flowLayoutPanel6";
            flowLayoutPanel6.Size = new Size(313, 33);
            flowLayoutPanel6.TabIndex = 32;
            // 
            // numRedeemTotal
            // 
            numRedeemTotal.Anchor = AnchorStyles.Left;
            numRedeemTotal.Increment = new decimal(new int[] { 100000, 0, 0, 0 });
            numRedeemTotal.Location = new Point(3, 3);
            numRedeemTotal.Maximum = new decimal(new int[] { 1410065408, 2, 0, 0 });
            numRedeemTotal.Name = "numRedeemTotal";
            numRedeemTotal.Size = new Size(257, 27);
            numRedeemTotal.TabIndex = 0;
            numRedeemTotal.ThousandsSeparator = true;
            numRedeemTotal.Value = new decimal(new int[] { 100000, 0, 0, 0 });
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Location = new Point(266, 6);
            label8.Name = "label8";
            label8.Size = new Size(44, 20);
            label8.TabIndex = 1;
            label8.Text = "đồng";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Left;
            label9.AutoSize = true;
            label9.Font = new Font("Inter", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(4, 365);
            label9.Name = "label9";
            label9.Size = new Size(157, 21);
            label9.TabIndex = 31;
            label9.Text = "Tổng tiền chuộc*";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Left;
            label10.AutoSize = true;
            label10.Font = new Font("Inter", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(465, 291);
            label10.Name = "label10";
            label10.Size = new Size(97, 21);
            label10.TabIndex = 33;
            label10.Text = "Trạng thái";
            // 
            // tbCustomerStatus
            // 
            tbCustomerStatus.Location = new Point(568, 287);
            tbCustomerStatus.Name = "tbCustomerStatus";
            tbCustomerStatus.Size = new Size(260, 27);
            tbCustomerStatus.TabIndex = 34;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Left;
            label11.AutoSize = true;
            label11.Font = new Font("Inter", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(568, 324);
            label11.Name = "label11";
            label11.Size = new Size(161, 21);
            label11.TabIndex = 35;
            label11.Text = "Ghi chú chỉnh sửa";
            // 
            // tbRedeemNote
            // 
            tbRedeemNote.Location = new Point(568, 358);
            tbRedeemNote.Name = "tbRedeemNote";
            tbRedeemNote.Size = new Size(260, 27);
            tbRedeemNote.TabIndex = 36;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.White;
            btnPrint.Font = new Font("Inter", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrint.ForeColor = Color.Black;
            btnPrint.Location = new Point(246, 412);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(140, 40);
            btnPrint.TabIndex = 39;
            btnPrint.Text = "In BN (F3)";
            btnPrint.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            btnClose.AutoSize = true;
            btnClose.BackColor = Color.White;
            btnClose.Font = new Font("Inter", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.Black;
            btnClose.Location = new Point(538, 412);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(140, 40);
            btnClose.TabIndex = 37;
            btnClose.Text = "Đóng (F5)";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.White;
            btnSave.Font = new Font("Inter", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.Black;
            btnSave.Location = new Point(392, 412);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(140, 40);
            btnSave.TabIndex = 38;
            btnSave.Text = "Lưu (F2)";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // CustomerRedeemForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(217, 255, 187);
            ClientSize = new Size(913, 463);
            Controls.Add(btnPrint);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(tbRedeemNote);
            Controls.Add(label11);
            Controls.Add(tbCustomerStatus);
            Controls.Add(label10);
            Controls.Add(flowLayoutPanel5);
            Controls.Add(label6);
            Controls.Add(flowLayoutPanel6);
            Controls.Add(dpRedeemDate);
            Controls.Add(label9);
            Controls.Add(label5);
            Controls.Add(tbAddCustomer);
            Name = "CustomerRedeemForm";
            Text = "Khách hàng chuộc đồ";
            tbAddCustomer.ResumeLayout(false);
            tbAddCustomer.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numProductWeight).EndInit();
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numProductRate).EndInit();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numProductFund).EndInit();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numProductPrice).EndInit();
            flowLayoutPanel5.ResumeLayout(false);
            flowLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numRedeemPrice).EndInit();
            flowLayoutPanel6.ResumeLayout(false);
            flowLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numRedeemTotal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tbAddCustomer;
        private Label lbCustomerId;
        private TextBox tbCustomerId;
        private Label lbCustomerName;
        private TextBox tbCustomerName;
        private TextBox tbNote;
        private Label lbNote;
        private ComboBox cbProductType;
        private Label lbProductType;
        private Label lbCustomerAddress;
        private TextBox tbCustomerAddress;
        private DateTimePicker dpCreatedAt;
        private Label lbCreatedAt;
        private Label lbCMND;
        private TextBox tbCMND;
        private TextBox tbProductName;
        private Label lbProductName;
        private FlowLayoutPanel flowLayoutPanel1;
        private NumericUpDown numProductWeight;
        private Label label1;
        private Label lbWeight;
        private FlowLayoutPanel flowLayoutPanel2;
        private NumericUpDown numProductPrice;
        private Label label2;
        private Label lbPrice;
        private Label lbFunds;
        private FlowLayoutPanel flowLayoutPanel4;
        private NumericUpDown numProductRate;
        private Label label4;
        private Label lbProductRate;
        private FlowLayoutPanel flowLayoutPanel3;
        private NumericUpDown numProductFund;
        private Label label3;
        private Label label5;
        private DateTimePicker dpRedeemDate;
        private Label label6;
        private FlowLayoutPanel flowLayoutPanel5;
        private NumericUpDown numRedeemPrice;
        private Label label7;
        private FlowLayoutPanel flowLayoutPanel6;
        private NumericUpDown numRedeemTotal;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox tbCustomerStatus;
        private Label label11;
        private TextBox tbRedeemNote;
        private Button btnPrint;
        private Button btnClose;
        private Button btnSave;
    }
}