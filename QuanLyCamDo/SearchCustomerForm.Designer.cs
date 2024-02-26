namespace QuanLyCamDo
{
    partial class SearchCustomerForm
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
            comboBox1 = new ComboBox();
            label2 = new Label();
            tbValue = new TextBox();
            label3 = new Label();
            dpFromDate = new DateTimePicker();
            label4 = new Label();
            dpToDate = new DateTimePicker();
            btnFilter = new Button();
            btnDelete = new Button();
            btnClose = new Button();
            btnSelect = new Button();
            label8 = new Label();
            btnExport = new Button();
            dtSearch = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dtSearch).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Inter", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(29, 32);
            label1.Name = "label1";
            label1.Size = new Size(94, 21);
            label1.TabIndex = 0;
            label1.Text = "Tìm trong";
            // 
            // comboBox1
            // 
            comboBox1.AutoCompleteCustomSource.AddRange(new string[] { "Số biên nhận", "Tên khách hàng", "Loại tài sản", "Tên tài sản", "Tiền vốn", "Tình trạng" });
            comboBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            comboBox1.DisplayMember = "1";
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Số biên nhận", "Tên khách hàng", "Loại tài sản", "Tên tài sản", "Tiền vốn", "Tình trạng" });
            comboBox1.Location = new Point(156, 30);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(260, 28);
            comboBox1.TabIndex = 1;
            comboBox1.Text = "Số biên nhận";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Inter", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(29, 74);
            label2.Name = "label2";
            label2.Size = new Size(121, 21);
            label2.TabIndex = 2;
            label2.Text = "Số biên nhận";
            // 
            // tbValue
            // 
            tbValue.Location = new Point(156, 72);
            tbValue.Name = "tbValue";
            tbValue.Size = new Size(260, 27);
            tbValue.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Inter", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(460, 32);
            label3.Name = "label3";
            label3.Size = new Size(111, 21);
            label3.TabIndex = 4;
            label3.Text = "Lọc từ ngày";
            // 
            // dpFromDate
            // 
            dpFromDate.Format = DateTimePickerFormat.Custom;
            dpFromDate.Location = new Point(577, 30);
            dpFromDate.Name = "dpFromDate";
            dpFromDate.Size = new Size(125, 27);
            dpFromDate.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Inter", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(708, 32);
            label4.Name = "label4";
            label4.Size = new Size(42, 21);
            label4.TabIndex = 6;
            label4.Text = "đến";
            // 
            // dpToDate
            // 
            dpToDate.Format = DateTimePickerFormat.Custom;
            dpToDate.Location = new Point(756, 30);
            dpToDate.Name = "dpToDate";
            dpToDate.Size = new Size(125, 27);
            dpToDate.TabIndex = 7;
            // 
            // btnFilter
            // 
            btnFilter.BackColor = Color.White;
            btnFilter.Font = new Font("Inter", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFilter.ForeColor = Color.Black;
            btnFilter.Location = new Point(88, 135);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(140, 40);
            btnFilter.TabIndex = 34;
            btnFilter.Text = "Lọc (F3)";
            btnFilter.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.AutoSize = true;
            btnDelete.BackColor = Color.White;
            btnDelete.Font = new Font("Inter", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.Black;
            btnDelete.Location = new Point(380, 135);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(140, 40);
            btnDelete.TabIndex = 32;
            btnDelete.Text = "Xóa (Delete)";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.White;
            btnClose.Font = new Font("Inter", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.Black;
            btnClose.Location = new Point(672, 135);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(140, 40);
            btnClose.TabIndex = 33;
            btnClose.Text = "Đóng (F5)";
            btnClose.UseVisualStyleBackColor = false;
            // 
            // btnSelect
            // 
            btnSelect.AutoSize = true;
            btnSelect.BackColor = Color.White;
            btnSelect.Font = new Font("Inter", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSelect.ForeColor = Color.Black;
            btnSelect.Location = new Point(526, 135);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(140, 40);
            btnSelect.TabIndex = 35;
            btnSelect.Text = "Chọn (F7)";
            btnSelect.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Inter", 14.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(0, 26, 255);
            label8.Location = new Point(67, 235);
            label8.Name = "label8";
            label8.Size = new Size(285, 30);
            label8.TabIndex = 36;
            label8.Text = "DANH SÁCH TÌM KIẾM";
            // 
            // btnExport
            // 
            btnExport.BackColor = Color.White;
            btnExport.Font = new Font("Inter", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExport.ForeColor = Color.Black;
            btnExport.Location = new Point(672, 681);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(140, 40);
            btnExport.TabIndex = 38;
            btnExport.Text = "Xuất Excel";
            btnExport.UseVisualStyleBackColor = false;
            // 
            // dtSearch
            // 
            dtSearch.AllowUserToOrderColumns = true;
            dtSearch.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtSearch.Location = new Point(67, 268);
            dtSearch.Name = "dtSearch";
            dtSearch.RowHeadersWidth = 51;
            dtSearch.Size = new Size(745, 407);
            dtSearch.TabIndex = 39;
            // 
            // SearchCustomerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(217, 255, 187);
            ClientSize = new Size(894, 733);
            Controls.Add(dtSearch);
            Controls.Add(btnExport);
            Controls.Add(label8);
            Controls.Add(btnSelect);
            Controls.Add(btnFilter);
            Controls.Add(btnDelete);
            Controls.Add(btnClose);
            Controls.Add(dpToDate);
            Controls.Add(label4);
            Controls.Add(dpFromDate);
            Controls.Add(label3);
            Controls.Add(tbValue);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            ForeColor = SystemColors.Control;
            Name = "SearchCustomerForm";
            Text = "Tìm kiếm khách hàng";
            ((System.ComponentModel.ISupportInitialize)dtSearch).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBox1;
        private Label label2;
        private TextBox tbValue;
        private Label label3;
        private DateTimePicker dpFromDate;
        private Label label4;
        private DateTimePicker dpToDate;
        private Button btnFilter;
        private Button btnDelete;
        private Button btnClose;
        private Button btnSelect;
        private Label label8;
        private Button btnExport;
        private DataGridView dtSearch;
    }
}