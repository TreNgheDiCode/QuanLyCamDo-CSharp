using System.Data;
using System.Data.OleDb;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace QuanLyCamDo
{
    public partial class CustomerExtendForm : Form
    {
        private short daysDiff = 0;
        private short monthsDiff = 0;
        private bool isFirst = false, isSecond = false, isThird = false;
        private DateTime first, second;
        private string customerId = "";

        public string CustomerId
        {
            set
            {
                customerId = value;
                tbCustomerId.Text = value;
                SetInitialData();
                if (!isThird && !isSecond && !isFirst)
                {
                    btnSave.Visible = false;
                    btnRedeem.Visible = true;
                    btnNew.Visible = true;
                }
            }
        }

        public void SetInitialData()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("SoThuTu");
            dt.Columns.Add("NgayGiaHan");
            dt.Columns.Add("NgayGiaoDichGiaHan");
            dt.Columns.Add("TienLaiGiaHan");

            for (int i = 0; i < 3; i++)
            {
                DataRow row = dt.NewRow();
                row["SoThuTu"] = i + 1;
                dt.Rows.Add(row);
            }

            lsHistory.DataSource = dt;

            try
            {
                if (MainForm.Conn.State == ConnectionState.Closed)
                    MainForm.Conn.Open();
                string sqlCommand = @"
                    SELECT * FROM BienNhan WHERE SoBienNhan=@id
                ";
                OleDbCommand command = new(sqlCommand, MainForm.Conn);
                command.Parameters.AddWithValue("@id", customerId);

                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
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

                    if (reader.IsDBNull(14)) isFirst = true;
                    if (reader.IsDBNull(17) && !isFirst) isSecond = true;
                    if (reader.IsDBNull(20) && !isSecond && !isFirst) isThird = true;

                    // Define a helper function to set row values
                    void SetRowValues(DataRow row, DateTime? ngayGiaHan, DateTime? ngayGiaoDichGiaHan, decimal? tienLaiGiaHan)
                    {
                        row["NgayGiaHan"] = ngayGiaHan?.ToString("dd/MM/yyyy") ?? "Không có thông tin";
                        row["NgayGiaoDichGiaHan"] = ngayGiaoDichGiaHan?.ToString("dd/MM/yyyy") ?? "Không có thông tin";
                        row["TienLaiGiaHan"] = tienLaiGiaHan?.ToString("N0") ?? "Không có thông tin";
                    }

                    // Use the helper function to set row values
                    foreach (DataRow row in dt.Rows)
                    {
                        int soThuTu = Convert.ToInt32(row["SoThuTu"]);

                        if (isFirst || (isSecond && soThuTu > 1) || (isThird && !isSecond && soThuTu > 2) || (!isThird && !isSecond && !isFirst && soThuTu > 3))
                        {
                            SetRowValues(row, null, null, null);
                        }
                        else
                        {
                            SetRowValues(row, reader.GetDateTime(10 + soThuTu * 3), reader.GetDateTime(11 + soThuTu * 3), reader.GetDecimal(12 + soThuTu * 3));
                        }
                    }

                    if (isFirst)
                    {
                        daysDiff = (short)dpCurrentExtendDate.Value.Subtract(dpCreatedAt.Value).Days;
                    }
                    else if (isSecond)
                    {
                        first = reader.GetDateTime(13);
                        daysDiff = (short)dpCurrentExtendDate.Value.Subtract(first).Days;
                    }
                    else if (isThird)
                    {
                        second = reader.GetDateTime(16);
                        daysDiff = (short)dpCurrentExtendDate.Value.Subtract(second).Days;
                    }

                    monthsDiff = (short)(daysDiff / 30);
                    dpActualExtendDate.Value = dpCreatedAt.Value.AddDays(30 * monthsDiff);

                    decimal rawValue = 0;

                    if (monthsDiff >= 1)
                    {
                        rawValue = 30 * monthsDiff * numProductPrice.Value * (numProductRate.Value / 3000m);
                    }
                    else if (monthsDiff < 1)
                    {
                        rawValue = daysDiff * numProductPrice.Value * (numProductRate.Value / 3000m);
                    }

                    numExtendPrice.Value = Math.Round(rawValue / 1000) * 1000;
                }

                reader.Close();
                MainForm.Conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ExtendCustomer()
        {
            try
            {
                if (MainForm.Conn.State == ConnectionState.Closed)
                    MainForm.Conn.Open();

                string updateQuery = "";
                OleDbCommand command = new();

                if (isFirst)
                {
                    updateQuery = @"
                        UPDATE BienNhan
                        SET NgayGH1=@ngayGiaHan, NgayGDGH1=@ngayGiaoDichGiaHan, TienLoiGH1=@tienLaiGiaHan
                        WHERE SoBienNhan=@id
                    ";
                }
                else if (isSecond)
                {
                    updateQuery = @"
                        UPDATE BienNhan
                        SET NgayGH2=@ngayGiaHan, NgayGDGH2=@ngayGiaoDichGiaHan, TienLoiGH2=@tienLaiGiaHan
                        WHERE SoBienNhan=@id
                    ";
                }
                else if (isThird)
                {
                    updateQuery = @"
                        UPDATE BienNhan
                        SET NgayGH3=@ngayGiaHan, NgayGDGH3=@ngayGiaoDichGiaHan, TienLoiGH3=@tienLaiGiaHan
                        WHERE SoBienNhan=@id
                    ";
                }

                command.CommandText = updateQuery;
                command.Connection = MainForm.Conn;
                command.Parameters.AddWithValue("@ngayGiaHan", dpActualExtendDate.Value.Date);
                command.Parameters.AddWithValue("@ngayGiaoDichGiaHan", dpCurrentExtendDate.Value.Date);
                command.Parameters.AddWithValue("@tienLaiGiaHan", numExtendPrice.Value);
                command.Parameters.AddWithValue("@id", customerId);

                command.ExecuteNonQuery();
                MessageBox.Show("Gia hạn thành công!");
                
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public CustomerExtendForm()
        {
            InitializeComponent();
            CenterToParent();
            ThemVaoDanhSachLoaiTaiSan();
            FormatDatePicker();
            DisableFields();
            ControlBox = false;
        }

        private void FormatDatePicker()
        {
            dpCreatedAt.Format = DateTimePickerFormat.Custom;
            dpCreatedAt.CustomFormat = "dd/MM/yyyy";

            dpActualExtendDate.Format = DateTimePickerFormat.Custom;
            dpActualExtendDate.CustomFormat = "dd/MM/yyyy";

            dpCurrentExtendDate.Format = DateTimePickerFormat.Custom;
            dpCurrentExtendDate.CustomFormat = "dd/MM/yyyy";
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            ExtendCustomer();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            // Update the customer status to "Đang chuộc"
            try
            {
                if (MainForm.Conn.State == ConnectionState.Closed)
                    MainForm.Conn.Open();

                string updateQuery = @"
                    UPDATE BienNhan
                    SET TinhTrang=1
                    WHERE SoBienNhan=@cusId
                ";
                OleDbCommand command = new(updateQuery, MainForm.Conn);
                command.Parameters.AddWithValue("@cusId", customerId);

                command.ExecuteNonQuery();
                MessageBox.Show("Tạo mới thành công!");
                MainForm.Conn.Close();
                // On success, create a new customer with the same information
                AddCustomerForm addCustomerForm = new();
                Close();
                addCustomerForm.SetFormValue(tbCustomerName.Text, tbCustomerAddress.Text, tbCMND.Text, cbProductType.Text, tbProductName.Text, numProductWeight.Value, numProductPrice.Value, numProductFund.Value, numProductRate.Value, tbNote.Text);
                addCustomerForm.ShowDialog();
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
