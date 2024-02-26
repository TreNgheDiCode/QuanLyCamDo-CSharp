using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCamDo
{
    public partial class AddProductTypeForm : Form
    {
        public static event EventHandler FormClosedEvent;
        public AddProductTypeForm()
        {
            InitializeComponent();
            CenterToParent();
            ControlBox = false;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                MainForm.Conn.Open();
                string sqlCommand = @"
                    INSERT INTO LoaiTaiSan(TenTaiSan)
                    VALUES (@tenTaiSan)
                ";
                OleDbCommand command = new(sqlCommand, MainForm.Conn);
                command.Parameters.AddWithValue("@tenTaiSan", tbProductType.Text);

                command.ExecuteNonQuery();

                MessageBox.Show("Thêm loại tài sản thành công");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { MainForm.Conn.Close(); }
        }

        private void AddProductTypeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormClosedEvent?.Invoke(sender, e);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
