using System.Data;
using System.Data.OleDb;

namespace QuanLyCamDo
{
    public partial class CustomerExtendForm : Form
    {
        public string CustomerId
        {
            set
            {
                tbCustomerId.Text = value;
            }
        }

        public string CustomerName
        {
            set
            {
                tbCustomerName.Text = value;
            }
        }

        public string CustomerAddress
        {
            set
            {
                tbCustomerAddress.Text = value;
            }
        }

        public string CMND
        {
            set
            {
                tbCMND.Text = value;
            }
        }

        public DateTime CreatedAt
        {
            set
            {
                dpCreatedAt.Value = value;
            }
        }

        public int ProductType
        {
            set
            {
                cbProductType.SelectedIndex = value - 1;
            }
        }

        public new string ProductName
        {
            set
            {
                tbProductName.Text = value;
            }
        }

        public double ProductWeight
        {
            set
            {
                numProductWeight.Value = (decimal)value;
            }
        }

        public double ProductPrice
        {
            set
            {
                numProductPrice.Value = (decimal)value;
            }
        }

        public double ProductFund
        {
            set
            {
                numProductFund.Value = (decimal)value;
            }
        }

        public double ProductRate
        {
            set
            {
                numProductRate.Value = (decimal)value;
            }
        }

        public string Note
        {
            set
            {
                tbNote.Text = value;
            }
        }

        public int CustomerStatus
        {
            set
            {
                tbCustomerStatus.Text = value switch
                {
                    0 => "Đang cầm",
                    1 => "Đã chuộc",
                    2 => "Đã quá hạn",
                    _ => "Không xác định"
                };
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
    }
}
