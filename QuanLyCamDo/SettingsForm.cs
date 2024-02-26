using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCamDo
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            CenterToParent();
            ControlBox = false;
            SetText();
        }

        private void SetText()
        {
            tbLocation.Enabled = false;
            if (MainForm.Conn == null)
            {
                tbLocation.Text = "Chưa chọn đường dẫn";
            } else
            {
                string[] connArray = MainForm.Conn.ConnectionString.Split(";");
                tbLocation.Text = connArray[1][12..];
            }
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Access Databases (*.accdb)|*.accdb";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog1.FileName;
                string extension = Path.GetExtension(fileName).ToLower();

                if (extension == ".accdb")
                {
                    tbLocation.Text = fileName;
                    MainForm.Conn = new($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={tbLocation.Text};Persist Security Info=False;");
                    Close();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn file dữ liệu hợp lệ", "File không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (tbLocation.Text == "Chưa chọn đường dẫn")
            {
                MessageBox.Show("Vui lòng chọn đường dẫn đến file dữ liệu", "File không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Close();
            }
        }
    }
}
