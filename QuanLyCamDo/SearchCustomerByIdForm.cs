using System.Data.OleDb;

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

                if (reader.Read() && reader.GetValue(0) != DBNull.Value)
                {
                    if (reader.GetString(0) != "" && formType == "extend")
                    {
                        CustomerExtendForm customerExtendForm = new()
                        {
                            CustomerId = reader.GetString(0),
                        };
                        Close();
                        customerExtendForm.ShowDialog();
                        return;
                    } else
                    {
                        CustomerRedeemForm customerRedeemForm = new()
                        {
                            CustomerId = reader.GetString(0),
                        };
                        Close();
                        customerRedeemForm.ShowDialog();
                        return;
                    }
                } else
                {
                    MessageBox.Show("Không tìm thấy biên nhận");
                }
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { MainForm.Conn.Close(); }
        }
    }
}
