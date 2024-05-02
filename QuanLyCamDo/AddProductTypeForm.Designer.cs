namespace QuanLyCamDo
{
    partial class AddProductTypeForm
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
            lbProductType = new Label();
            tbProductType = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnClose = new Button();
            btnCreate = new Button();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // lbProductType
            // 
            lbProductType.Anchor = AnchorStyles.Left;
            lbProductType.AutoSize = true;
            lbProductType.Font = new Font("Inter", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbProductType.ForeColor = Color.Black;
            lbProductType.Location = new Point(3, 6);
            lbProductType.Name = "lbProductType";
            lbProductType.Size = new Size(139, 21);
            lbProductType.TabIndex = 0;
            lbProductType.Text = "Tên loại tài sản";
            // 
            // tbProductType
            // 
            tbProductType.Location = new Point(148, 3);
            tbProductType.Name = "tbProductType";
            tbProductType.Size = new Size(225, 27);
            tbProductType.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.Controls.Add(lbProductType);
            flowLayoutPanel1.Controls.Add(tbProductType);
            flowLayoutPanel1.Location = new Point(12, 12);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(376, 33);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // btnClose
            // 
            btnClose.AutoSize = true;
            btnClose.BackColor = Color.White;
            btnClose.Font = new Font("Inter", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.Black;
            btnClose.Location = new Point(246, 51);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(140, 40);
            btnClose.TabIndex = 30;
            btnClose.Text = "Đóng (F5)";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnCreate
            // 
            btnCreate.AutoSize = true;
            btnCreate.BackColor = Color.White;
            btnCreate.Font = new Font("Inter", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreate.ForeColor = Color.Black;
            btnCreate.Location = new Point(100, 51);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(140, 40);
            btnCreate.TabIndex = 31;
            btnCreate.Text = "Lưu (F2)";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // AddProductTypeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(247, 255, 241);
            ClientSize = new Size(800, 450);
            Controls.Add(btnCreate);
            Controls.Add(btnClose);
            Controls.Add(flowLayoutPanel1);
            Name = "AddProductTypeForm";
            Text = "Thêm loại tài sản";
            FormClosed += AddProductTypeForm_FormClosed;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbProductType;
        private TextBox tbProductType;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnClose;
        private Button btnCreate;
    }
}