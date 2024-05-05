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
    public partial class CustomerRedeemForm : Form
    {
        private short daysDiff = 0;
        private short monthsDiff = 0;
        private bool isFirst = false, isSecond = false, isThird = false;
        private DateTime first, second;

        public string CustomerId
        {
            set
            {
                tbCustomerId.Text = value;
                SetInitialData();
            }
        }

        public void SetInitialData()
        {
            try
            {
                if (MainForm.Conn.State == ConnectionState.Closed)
                    MainForm.Conn.Open();
                string sqlCommand = @"
                    SELECT * FROM BienNhan WHERE SoBienNhan=@id
                ";
                OleDbCommand command = new(sqlCommand, MainForm.Conn);
                command.Parameters.AddWithValue("@id", tbCustomerId.Text);

                OleDbDataReader reader = command.ExecuteReader();

                if (reader.Read() && reader.GetValue(0) != DBNull.Value)
                {
                    tbCustomerName.Text = reader.GetString(1);
                    tbCustomerAddress.Text = reader.GetString(2);
                    tbCMND.Text = reader.GetString(3);
                    dpCreatedAt.Value = reader.GetDateTime(4);
                    cbProductType.SelectedIndex = reader.GetInt32(5) - 1;
                    tbProductName.Text = reader.GetString(6);
                    numProductWeight.Value = reader.GetDecimal(7);
                    numProductPrice.Value = reader.GetDecimal(8);
                    numProductFund.Value = reader.GetDecimal(9);
                    numProductRate.Value = reader.GetDecimal(10);
                    tbNote.Text = reader.GetString(11);
                    tbCustomerStatus.Text = reader.GetInt32(12) switch
                    {
                        0 => "Đang cầm",
                        1 => "Đã chuộc",
                        2 => "Đã quá hạn",
                        _ => "Không xác định"
                    };
                    numRedeemRate.Value = reader.GetDecimal(10);

                    if (reader.IsDBNull(14)) isFirst = true;
                    if (reader.IsDBNull(17) && !isFirst) isSecond = true;
                    if (reader.IsDBNull(20) && !isSecond && !isFirst) isThird = true;

                    if (isFirst)
                    {
                        daysDiff = (short)dpCurrentRedeemDate.Value.Subtract(dpCreatedAt.Value).Days;
                    }
                    else if (isSecond)
                    {
                        first = reader.GetDateTime(13);
                        daysDiff = (short)dpCurrentRedeemDate.Value.Subtract(first).Days;
                    }
                    else if (isThird)
                    {
                        second = reader.GetDateTime(16);
                        daysDiff = (short)dpCurrentRedeemDate.Value.Subtract(second).Days;
                    }

                    monthsDiff = (short)(daysDiff / 30);
                    dpRedeemDate.Value = dpCreatedAt.Value.AddDays(30 * monthsDiff);

                    decimal rawValue = 0;

                    if (monthsDiff >= 1)
                    {
                        rawValue = 30 * monthsDiff * numProductPrice.Value * (numProductRate.Value / 3000m);
                    }
                    else if (monthsDiff < 1)
                    {
                        rawValue = daysDiff * numProductPrice.Value * (numProductRate.Value / 3000m);
                    }

                    numRedeemPrice.Value = Math.Round(rawValue / 1000) * 1000;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public CustomerRedeemForm()
        {
            InitializeComponent();
            CenterToParent();
            ThemVaoDanhSachLoaiTaiSan();
            FormatDatePicker();
            DisableFields();
        }

        private void FormatDatePicker()
        {
            dpCreatedAt.Format = DateTimePickerFormat.Custom;
            dpCreatedAt.CustomFormat = "dd/MM/yyyy";

            dpRedeemDate.Format = DateTimePickerFormat.Custom;
            dpRedeemDate.CustomFormat = "dd/MM/yyyy";

            dpCurrentRedeemDate.Format = DateTimePickerFormat.Custom;
            dpCurrentRedeemDate.CustomFormat = "dd/MM/yyyy";
        }

        private void DisableFields()
        {
            tbCustomerId.Enabled = false;
            tbCustomerName.Enabled = false;
            tbCustomerAddress.Enabled = false;
            tbCMND.Enabled = false;
            dpCreatedAt.Enabled = false;
            cbProductType.Enabled = false;
            tbProductName.Enabled = false;
            numProductFund.Enabled = false;
            numProductRate.Enabled = false;
            numProductPrice.Enabled = false;
            numProductWeight.Enabled = false;
            tbCustomerStatus.Enabled = false;
        }

        private void ThemVaoDanhSachLoaiTaiSan()
        {
            try
            {
                if (MainForm.Conn.State == ConnectionState.Closed)
                    MainForm.Conn.Open();
                string sqlCommand = @"
                    SELECT TenTaiSan FROM LoaiTaiSan
                ";
                OleDbCommand command = new(sqlCommand, MainForm.Conn);

                OleDbDataReader reader = command.ExecuteReader();
                cbProductType.Items.Clear();

                while (reader.Read())
                {
                    cbProductType.Items.Add(reader[0].ToString()!);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
