using System.Data;
using System.Data.OleDb;
using static System.Windows.Forms.AxHost;
using System.Windows.Forms;
using System.Globalization;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing.Printing;

namespace QuanLyCamDo
{
    public partial class AddCustomerForm : Form
    {
        private readonly DataTable dataTable = new();
        public AddCustomerForm()
        {
            InitializeComponent();
            CenterToParent();
            GetLatestCustomerId();
            ControlBox = false;
            ThemVaoDanhSachLoaiTaiSan();
            AddProductTypeForm.FormClosedEvent += CapNhatDanhSachLoaiTaiSan;
            tbCustomerId.Enabled = false;
            dpCreatedAt.Format = DateTimePickerFormat.Custom;
            dpCreatedAt.CustomFormat = "dd/MM/yyyy";
            CultureInfo.CurrentCulture = new CultureInfo("vi-VN", false);
        }
        private void lbBtnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateData()) return;
            ThemBienNhan();
            btnSave.Enabled = false;
        }
        private void lbBtnSave_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                ThemBienNhan();
            }
        }
        private bool ValidateData()
        {
            if (tbCustomerName.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng", "Thông tin không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (dpCreatedAt.Value > DateTime.Now)
            {
                MessageBox.Show("Ngày cầm không được lớn hơn ngày hiện tại", "Thông tin không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (cbProductType.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng chọn hoặc thêm mới loại tài sản", "Thông tin không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (tbProductName.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập tên tài sản", "Thông tin không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if ((cbProductType.Text.ToLower().Trim().Contains("vàng") || cbProductType.Text.ToLower().Trim().Contains("vang")) && numProductWeight.Value == 0)
            {
                MessageBox.Show("Vui lòng nhập số chỉ cho loại tài sản liên quan đến vàng", "Thông tin không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        private void ThemBienNhan()
        {
            try
            {
                MainForm.Conn.Open();
                OleDbCommand command = null;

                string sqlCommand = @"
                    SELECT Id FROM LoaiTaiSan WHERE TenTaiSan=@typeName
                ";

                command = new(sqlCommand, MainForm.Conn);
                command.Parameters.AddWithValue("@typeName", cbProductType.Text);

                OleDbDataReader reader = command.ExecuteReader();

                int typeId;
                if (reader.Read())
                    typeId = reader.GetInt32(0);
                else
                {
                    typeId = 6;
                }

                reader.Close();

                string nonQueryString = @"
                    INSERT INTO BienNhan(
                        SoBienNhan, 
                        TenKhachHang,
                        DiaChi,
                        SoCMND,
                        NgayCam,
                        LoaiTaiSan,
                        TenTaiSan,
                        TrongLuongVang,
                        TriGia,
                        TienVon,
                        LaiSuat,
                        GhiChu,
                        TinhTrang
                    )
                    VALUES (
                        @id,
                        @name,
                        @address,
                        @cmnd,
                        @created,
                        @typeId,
                        @productName,
                        @weight,
                        @price,
                        @fund,
                        @rate,
                        @note,
                        @status
                    )
                ";

                command = new(nonQueryString, MainForm.Conn);

                command.Parameters.AddWithValue("@id", tbCustomerId.Text);
                command.Parameters.AddWithValue("@name", tbCustomerName.Text);
                command.Parameters.AddWithValue("@address", tbCustomerAddress.Text);
                command.Parameters.AddWithValue("@cmnd", tbCMND.Text);
                command.Parameters.AddWithValue("@created", dpCreatedAt.Value.Date);
                command.Parameters.AddWithValue("@typeId", typeId);
                command.Parameters.AddWithValue("@productName", tbProductName.Text);
                command.Parameters.AddWithValue("@weight", numProductWeight.Value);
                command.Parameters.AddWithValue("@price", numProductPrice.Value);
                command.Parameters.AddWithValue("@fund", numProductFund.Value);
                command.Parameters.AddWithValue("@rate", numProductRate.Value);
                command.Parameters.AddWithValue("@note", tbNote.Text);
                command.Parameters.AddWithValue("@status", 0);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Thêm khách hàng mới thành công");
                    string idQuery = "SELECT * FROM BienNhan WHERE SoBienNhan=@id";
                    command = new(idQuery, MainForm.Conn);
                    command.Parameters.AddWithValue("@id", tbCustomerId.Text);

                    reader = command.ExecuteReader();
                    dataTable.Load(reader);

                    if (listCustomers.Rows.Count == 0)
                    {
                        listCustomers.DataSource = dataTable;
                    }

                    reader.Close();
                }
                else
                {
                    MessageBox.Show("Thêm khách hàng thất bại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { MainForm.Conn.Close(); }
        }

        private void GetLatestCustomerId()
        {
            try
            {
                MainForm.Conn.Open();
                string sqlCommand = @"
                    SELECT TOP 1 SoBienNhan FROM BienNhan
                    ORDER BY SoBienNhan DESC
                ";

                OleDbCommand command = new(sqlCommand, MainForm.Conn);

                OleDbDataReader reader = command.ExecuteReader();

                if (!reader.HasRows)
                {
                    string[] arrDate = DateTime.Now.ToShortDateString().Split("/");
                    string prefix = arrDate[0].PadLeft(2, '0') + arrDate[2][2..];
                    tbCustomerId.Text = prefix + ".0001";
                }

                while (reader.Read())
                {
                    string[] customerIdPattern = reader.GetString(0).Split(".");
                    int incrementValue = Convert.ToInt16(customerIdPattern[1]) + 1;
                    tbCustomerId.Text = customerIdPattern[0] + "." + incrementValue.ToString().PadLeft(4, '0');
                    break;
                }

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

        private void ThemVaoDanhSachLoaiTaiSan()
        {
            try
            {
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
            finally
            {
                MainForm.Conn.Close();
            }
        }
        private void CapNhatDanhSachLoaiTaiSan(object sender, EventArgs e)
        {
            ThemVaoDanhSachLoaiTaiSan();
        }
        private void btnAddProductType_Click(object sender, EventArgs e)
        {
            AddProductTypeForm addProductTypeForm = new();
            addProductTypeForm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn tiếp tục?", "Đặt về mặc định", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                ResetFields();
                GetLatestCustomerId();
                btnSave.Enabled = true;
            }
        }

        private void ResetFields()
        {
            tbCustomerId.Text = "";
            tbCustomerName.Text = "";
            tbCustomerAddress.Text = "";
            tbCMND.Text = "";
            dpCreatedAt.Value = DateTime.Now;
            cbProductType.SelectedIndex = 0;
            tbProductName.Text = "";
            numProductFund.Value = 0;
            numProductPrice.Value = 0;
            numProductWeight.Value = 0;
            numProductRate.Value = 0;
            tbNote.Text = "";
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printDialog.ShowDialog();
        }

        private string GetProductTypeName(int id)
        {
            try
            {
                MainForm.Conn.Open();
                OleDbCommand command = null;

                string sqlCommand = @"
                    SELECT TenTaiSan FROM LoaiTaiSan WHERE Id=@id
                ";

                command = new(sqlCommand, MainForm.Conn);
                command.Parameters.AddWithValue("@id", id);

                OleDbDataReader reader = command.ExecuteReader();

                string typeName;
                if (reader.Read())
                    typeName = reader.GetString(0);
                else
                {
                    typeName = "Không xác định";
                }

                reader.Close();
                return typeName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return "";
            }
            finally
            {
                MainForm.Conn.Close();
            }
        }

        string[] words =
            [
                "không",
                "một",
                "hai",
                "ba",
                "bốn",
                "năm",
                "sáu",
                "bảy",
                "tám",
                "chín",
                "mười",
                "mười một",
                "mười hai",
                "mười ba",
                "mười bốn",
                "mười lăm",
                "mười sáu",
                "mười bảy",
                "mười tám",
                "mười chín"
            ];

        string[] units = [
            "",
            "nghìn",
            "triệu",
            "tỷ"
        ];

        private string ConvertPriceToText(double number)
        {
            if (number <= 0)
            {
                return "Không đồng";
            }

            int integralPart = (int)Math.Floor(number);

            string text = ConvertIntergerPartToText(integralPart);

            return text + " đồng";
        }

        private string ConvertIntergerPartToText(int number)
        {
            string text = "";
            int unitIndex = 0;

            while (number > 0)
            {
                int threeDigitGroup = number % 1000;
                text = ConvertThreeDigitGroupToText(threeDigitGroup) + " " + units[unitIndex] + " " + text;
                number /= 1000;
                unitIndex++;
            }

            return text.Trim();
        }

        private string ConvertThreeDigitGroupToText(int number)
        {
            string text = "";

            int hundred = number / 100;
            number %= 100;

            if (hundred > 0)
            {
                text = words[hundred] + " trăm ";
            }

            if (number > 0)
            {
                if (hundred > 0 && number < 10)
                {
                    text += "lẻ ";
                }
                text += ConvertTwoDigitNumberToText(number);
            }

            return text.Trim();
        }

        private string ConvertTwoDigitNumberToText(int number)
        {
            if (number == 0)
            {
                return "";
            }

            int ten = number / 10;
            int unit = number % 10;

            if (ten == 1)
            {
                return words[unit + 10];
            }
            else
            {
                return words[ten] + " mươi " + words[unit];
            }
        }

        int i = 0;

        private void print_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font defaultFont = new("Inter", 14, FontStyle.Regular, GraphicsUnit.Point);
            Font italicFont = new("Inter", 14, FontStyle.Italic, GraphicsUnit.Point);
            Font boldFont = new("Inter", 14, FontStyle.Bold, GraphicsUnit.Point);

            StringFormat textCenterFormat = new()
            {
                FormatFlags = StringFormatFlags.NoClip,
                Alignment = StringAlignment.Center,
                Trimming = StringTrimming.EllipsisCharacter,
            };

            StringFormat textLeftFormat = new()
            {
                FormatFlags = StringFormatFlags.NoClip,
                Alignment = StringAlignment.Near,
                Trimming = StringTrimming.EllipsisCharacter,
            };

            int lMargin = e.MarginBounds.Left;

            // Giá trị mặc định
            float leading = 4;

            // Tổng độ cao thông tin (tính cả Lãi suất)
            float totalContentHeight = 0;
            totalContentHeight += boldFont.Height;
            // Khoảng cách giữa lãi suất và dòng đầu tiên sẽ cao hơn
            totalContentHeight += leading * 2 + defaultFont.Height;
            // Tổng các dòng còn lại (Trừ lãi suất và tên)
            totalContentHeight += (leading + defaultFont.Height) * 6;

            // Tính toán kích thước vùng được in ban đầu
            RectangleF printableArea = print.DefaultPageSettings.PrintableArea; // Full trang được chọn
            float startY = printableArea.Height / 4 - totalContentHeight / 2; // Độ cao ban đầu
            float offset = 0;
            SizeF layoutSize = new(printableArea.Width, boldFont.Height); // Khung chữ 
            RectangleF layout = new(new PointF(0, startY + offset), layoutSize); // Vị trí sẽ in


            // Lặp đến khi không còn hàng nào để đọc
            while (i < listCustomers.Rows.Count - 1)
            {
                DataGridViewRow row = listCustomers.Rows[i];

                DataGridViewCellCollection cells = row.Cells;

                // Chuỗi hiển thị
                string rateString = $"Lãi suất: ";
                string labelName = "Tên khách: ";
                string labelAddress = "Địa chỉ: ";
                string labelType = "Loại Tài Sản: ";
                string labelPName = "Tên tài sản: ";
                string labelWeight = "Trọng lượng: ";
                string labelPrice = "Trị giá: ";
                string labelFund = "Số tiền cầm: ";
                string labelDate = "Ngày cầm: ";

                // In giá trị lãi suất
                rateString += cells[10].Value + " %/Tháng";
                e.Graphics.DrawString(rateString, boldFont, Brushes.Black, layout, textCenterFormat);
                offset += leading * 2 + boldFont.Height;

                // In Tên khách
                layoutSize = new(printableArea.Width, defaultFont.Height);
                layout = new(new PointF(lMargin, startY + offset), layoutSize);
                e.Graphics.DrawString(labelName, defaultFont, Brushes.Black, layout, textLeftFormat);
                layoutSize = new(printableArea.Width, italicFont.Height);
                layout = new(new PointF(lMargin + e.Graphics.MeasureString(labelName, defaultFont).Width, startY + offset), layoutSize);
                e.Graphics.DrawString(cells[1].Value.ToString(), italicFont, Brushes.Black, layout, textLeftFormat);
                offset += leading + defaultFont.Height;

                // In địa chỉ
                layout = new(new PointF(lMargin, startY + offset), layoutSize);
                e.Graphics.DrawString(labelAddress, defaultFont, Brushes.Black, layout, textLeftFormat);
                layoutSize = new(printableArea.Width, italicFont.Height);
                layout = new(new PointF(lMargin + e.Graphics.MeasureString(labelAddress, defaultFont).Width, startY + offset), layoutSize);
                e.Graphics.DrawString(cells[2].Value.ToString(), italicFont, Brushes.Black, layout, textLeftFormat);
                offset += leading + defaultFont.Height;

                // In Loại tài sản
                string type = (string)cbProductType.Items[(int)cells[5].Value - 1]; // Lấy tên loại tài sản
                layout = new(new PointF(lMargin, startY + offset), layoutSize);
                e.Graphics.DrawString(labelType, defaultFont, Brushes.Black, layout, textLeftFormat);
                layoutSize = new(printableArea.Width, italicFont.Height);
                layout = new(new PointF(lMargin + e.Graphics.MeasureString(labelType, defaultFont).Width, startY + offset), layoutSize);
                e.Graphics.DrawString(type, italicFont, Brushes.Black, layout, textLeftFormat);
                offset += leading + defaultFont.Height;

                // In Tên tài sản
                layout = new(new PointF(lMargin, startY + offset), layoutSize);
                e.Graphics.DrawString(labelPName, defaultFont, Brushes.Black, layout, textLeftFormat);
                layoutSize = new(printableArea.Width, italicFont.Height);
                layout = new(new PointF(lMargin + e.Graphics.MeasureString(labelPName, defaultFont).Width, startY + offset), layoutSize);
                e.Graphics.DrawString(cells[6].Value.ToString(), italicFont, Brushes.Black, layout, textLeftFormat);
                offset += leading + defaultFont.Height;

                // In Trọng lượng & Trị giá
                layout = new(new PointF(lMargin, startY + offset), layoutSize);
                e.Graphics.DrawString(labelWeight, defaultFont, Brushes.Black, layout, textLeftFormat);
                layoutSize = new(printableArea.Width, italicFont.Height);
                layout = new(new PointF(lMargin + e.Graphics.MeasureString(labelWeight, defaultFont).Width, startY + offset), layoutSize);
                e.Graphics.DrawString(cells[7].Value.ToString() + " chỉ", italicFont, Brushes.Black, layout, textLeftFormat);
                layoutSize = new(printableArea.Width, defaultFont.Height);
                layout = new(new PointF(lMargin + e.Graphics.MeasureString(labelWeight + cells[7].Value.ToString() + " chỉ", defaultFont).Width, startY + offset), layoutSize);
                e.Graphics.DrawString("; " + labelPrice, defaultFont, Brushes.Black, layout, textLeftFormat);
                layoutSize = new(printableArea.Width, defaultFont.Height);
                layout = new(new PointF(lMargin + e.Graphics.MeasureString(labelWeight + cells[7].Value.ToString() + " chỉ" + "; " + labelPrice, defaultFont).Width, startY + offset), layoutSize);
                e.Graphics.DrawString(string.Format("{0:0,0 đồng}", cells[8].Value), italicFont, Brushes.Black, layout, textLeftFormat);
                offset += leading + defaultFont.Height;

                // In Số tiền cầm
                string covertPriceToText = ConvertPriceToText((double)cells[9].Value);
                layout = new(new PointF(lMargin, startY + offset), layoutSize);
                e.Graphics.DrawString(labelFund, defaultFont, Brushes.Black, layout, textLeftFormat);
                layoutSize = new(printableArea.Width, italicFont.Height);
                layout = new(new PointF(lMargin + e.Graphics.MeasureString(labelFund, defaultFont).Width, startY + offset), layoutSize);
                e.Graphics.DrawString(string.Format("{0:0,0 đồng}" + " (" + covertPriceToText + ")", cells[9].Value), italicFont, Brushes.Black, layout, textLeftFormat);
                offset += leading + defaultFont.Height;

                // In Ngày cầm
                string dateValue = ((DateTime)cells[4].Value).ToShortDateString();
                layout = new(new PointF(lMargin, startY + offset), layoutSize);
                e.Graphics.DrawString(labelDate, defaultFont, Brushes.Black, layout, textLeftFormat);
                layoutSize = new(printableArea.Width, italicFont.Height);
                layout = new(new PointF(lMargin + e.Graphics.MeasureString(labelDate, defaultFont).Width, startY + offset), layoutSize);
                e.Graphics.DrawString(dateValue, italicFont, Brushes.Black, layout, textLeftFormat);

                // Nhảy xuống nửa dưới
                startY += printableArea.Height / 2;
                offset = 0;
                layoutSize = new(printableArea.Width, boldFont.Height); // Khung chữ 
                layout = new(new PointF(0, startY + offset), layoutSize); // Vị trí sẽ in

                i++;

                if (startY >= e.MarginBounds.Height + e.MarginBounds.Top)
                {
                    e.HasMorePages = true;
                    return;
                }
            }

            e.HasMorePages = false;
        }

        private void print_BeginPrint(object sender, PrintEventArgs e)
        {
            i = 0;
        }
    }
} 