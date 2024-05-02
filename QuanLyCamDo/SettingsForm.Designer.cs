namespace QuanLyCamDo
{
    partial class SettingsForm
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
            tbLocation = new TextBox();
            openFileDialog1 = new OpenFileDialog();
            btnChooseFile = new Button();
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
            label1.Size = new Size(182, 21);
            label1.TabIndex = 0;
            label1.Text = "Đưởng dẫn thư mục";
            // 
            // tbLocation
            // 
            tbLocation.Location = new Point(200, 7);
            tbLocation.Name = "tbLocation";
            tbLocation.Size = new Size(394, 27);
            tbLocation.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnChooseFile
            // 
            btnChooseFile.BackColor = Color.White;
            btnChooseFile.FlatStyle = FlatStyle.Flat;
            btnChooseFile.Location = new Point(600, 6);
            btnChooseFile.Name = "btnChooseFile";
            btnChooseFile.Size = new Size(94, 29);
            btnChooseFile.TabIndex = 2;
            btnChooseFile.Text = "Chọn...";
            btnChooseFile.UseVisualStyleBackColor = false;
            btnChooseFile.Click += btnChooseFile_Click;
            // 
            // btnClose
            // 
            btnClose.AutoSize = true;
            btnClose.BackColor = Color.White;
            btnClose.Font = new Font("Inter", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.Black;
            btnClose.Location = new Point(554, 41);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(140, 40);
            btnClose.TabIndex = 3;
            btnClose.Text = "Đóng (F5)";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(247, 255, 241);
            ClientSize = new Size(800, 450);
            Controls.Add(btnClose);
            Controls.Add(btnChooseFile);
            Controls.Add(tbLocation);
            Controls.Add(label1);
            Name = "SettingsForm";
            Text = "Đường dẫn";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private OpenFileDialog openFileDialog1;
        private Button btnChooseFile;
        private Button btnClose;
        private TextBox tbLocation;
    }
}