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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            CenterToScreen();
            MainForm.AssignDatabase();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            tbPassword.PasswordChar = '*';
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            try
            {
                MainForm.Conn.Open();

                string sqlCommand = @"
                    SELECT * FROM TaiKhoan
                    WHERE TenDangNhap=@username
                    AND MatKhau=@password
                ";

                OleDbCommand command = new(sqlCommand, MainForm.Conn);
                command.Parameters.AddWithValue("@username", tbUsername.Text);
                command.Parameters.AddWithValue("@password", tbPassword.Text);

                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (reader.GetInt32(0) > 0)
                    {
                        MessageBox.Show("Đăng nhập thành công", "Đăng nhập");
                        MainForm mainForm = new();
                        mainForm.Show();
                        Hide();
                    }
                    reader.Close();
                    return;
                }

                MessageBox.Show("Sai thông tin tài khoản");
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                MainForm.Conn.Close();
            }
        }
    }
}
