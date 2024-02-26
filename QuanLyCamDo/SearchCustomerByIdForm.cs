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
    public partial class SearchCustomerByIdForm : Form
    {
        private string formType = "extend";
        public string FormType
        {
            set
            {
                formType = value;
            }
        }
        public SearchCustomerByIdForm()
        {
            InitializeComponent();
            CenterToParent();
            ControlBox = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            if (tbCustomerId.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã số biên nhận");
                return;
            }

            try
            {
                MainForm.Conn.Open();
                string sqlCommand = @"
                    SELECT * FROM BienNhan WHERE SoBienNhan=@id                
                ";

                OleDbCommand command = new(sqlCommand, MainForm.Conn);
                command.Parameters.AddWithValue("@id", tbCustomerId.Text);

                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (reader.GetString(0) != "" && formType == "extend")
                    {   
                        CustomerExtendForm customerExtendForm = new()
                        {
                            CustomerId = reader.GetString(0),
                            CustomerName = reader.GetString(1),
                            CustomerAddress = reader.GetString(2),
                            CMND = reader.GetString(3),
                            CreatedAt = reader.GetDateTime(4),
                            ProductType = reader.GetInt32(5),
                            ProductName = reader.GetString(6),
                            ProductWeight = reader.GetDouble(7),
                            ProductPrice = reader.GetDouble(8),
                            ProductFund = reader.GetDouble(9),
                            ProductRate = reader.GetDouble(10),
                            Note = reader.GetString(11),
                        };
                        Close();
                        customerExtendForm.ShowDialog();
                        return;
                    } else
                    {
                        CustomerRedeemForm customerRedeemForm = new()
                        {
                            CustomerId = reader.GetString(0),
                            CustomerName = reader.GetString(1),
                            CustomerAddress = reader.GetString(2),
                            CMND = reader.GetString(3),
                            CreatedAt = reader.GetDateTime(4),
                            ProductType = reader.GetInt32(5),
                            ProductName = reader.GetString(6),
                            ProductWeight = reader.GetDouble(7),
                            ProductPrice = reader.GetDouble(8),
                            ProductFund = reader.GetDouble(9),
                            ProductRate = reader.GetDouble(10),
                            Note = reader.GetString(11),
                        };
                        Close();
                        customerRedeemForm.ShowDialog();
                        return;
                    }
                }
                MessageBox.Show("Không tìm thấy biên nhận");
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { MainForm.Conn.Close(); }
        }
    }
}
