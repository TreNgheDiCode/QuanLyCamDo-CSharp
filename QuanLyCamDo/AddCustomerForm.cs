
using System.Data;
using System.Data.OleDb;
using System.Globalization;
using System.Drawing.Printing;
using Word = Microsoft.Office.Interop.Word;
using System.Reflection;
using System.Windows.Forms;

namespace QuanLyCamDo
{
    public partial class AddCustomerForm : Form
    {
        private readonly DataTable dataTable = new();
        private readonly Utility utility = new();

        // Set value for form
        public void SetFormValue(string customerName, string customerAddress, string cmnd, string productType, string productName, decimal productWeight, decimal productPrice, decimal productFund, decimal productRate, string note)
        {
            GetLatestCustomerId();
            tbCustomerName.Text = customerName;
            tbCustomerAddress.Text = customerAddress;
            tbCMND.Text = cmnd;
            cbProductType.Text = productType;
            tbProductName.Text = productName;
            numProductWeight.Value = productWeight;
            numProductPrice.Value = productPrice;
            numProductFund.Value = productFund;
            numProductRate.Value = productRate;
            tbNote.Text = note;
        }

        public AddCustomerForm()
        {
            InitializeComponent();
            CenterToParent();
            GetLatestCustomerId();
            ControlBox = false;
            ThemVaoDanhSachLoaiTaiSan();
            AddProductTypeForm.FormClosedEvent += CapNhatDanhSachLoaiTaiSan;
            dpCreatedAt.Format = DateTimePickerFormat.Custom;
            dpCreatedAt.CustomFormat = "dd/MM/yyyy";
            CultureInfo.CurrentCulture = new CultureInfo("vi-VN", false);
        }
        private void lbBtnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateData()) return;
            ThemBienNhan();
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

            if (numProductFund.Value == 0)
            {
                MessageBox.Show("Vui lòng nhập tiền vốn lớn hơn 0", "Thông tin không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (numProductRate.Value == 0)
            {
                MessageBox.Show("Vui lòng nhập lãi suất lớn hơn 0", "Thông tin không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    btnSave.Enabled = false;
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
                    WHERE MONTH(NgayCam) = MONTH(Date())
                    ORDER BY SoBienNhan DESC
                ";

                OleDbCommand command = new(sqlCommand, MainForm.Conn);

                OleDbDataReader reader = command.ExecuteReader();

                string[] arrDate = DateTime.Now.ToShortDateString().Split("/");
                string prefix = arrDate[0].PadLeft(2, '0') + arrDate[2][2..];
                if (!reader.HasRows)
                {
                    tbCustomerId.Text = prefix + ".0001";
                }

                while (reader.Read())
                {
                    string[] customerIdPattern = reader.GetString(0).Split(".");
                    int incrementValue = Convert.ToInt16(customerIdPattern[1]) + 1;
                    tbCustomerId.Text = prefix + "." + incrementValue.ToString().PadLeft(4, '0');
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
            // Path to the Word document
            string docPath = @"D:\\LamViec\\QuanLyCamDo\\mailmerge-test.docx";

            // Create a new Word application
            var wordApp = new Word.Application();

            // Open the Word document
            var wordDoc = wordApp.Documents.Open(docPath);

            // Check if the file is read-only
            if (new FileInfo(docPath).IsReadOnly)
            {
                // Change the file's read-only status
                File.SetAttributes(docPath, File.GetAttributes(docPath) & ~FileAttributes.ReadOnly);
            }

            // Loop through each row in the DataGridView
            for (int i = 0; i < listCustomers.Rows.Count - 1; i++)
            {
                DataGridViewRow row = listCustomers.Rows[i];

                // Get the values from the DataGridView row
                string customerId = row.Cells["SoBienNhan"].Value.ToString()!;
                string productRate = row.Cells["LaiSuat"].Value.ToString()! + " %/Tháng";
                string customerName = row.Cells["TenKhachHang"].Value.ToString()!;
                string customerAddress = row.Cells["DiaChi"].Value.ToString()!;
                string productTypeName = GetProductTypeName((int)row.Cells["LoaiTaiSan"].Value)!;
                string productWeight = row.Cells["TrongLuongVang"].Value.ToString()! + " chỉ";
                MessageBox.Show(string.Format("{0:0,0 đồng}", row.Cells["TriGia"].Value.ToString()!));
                string productPrice = string.Format("{0:0,0 đồng}", row.Cells["TriGia"].Value.ToString()!);
                string productFund = string.Format("{0:0,0 đồng}" + " (" + utility.ConvertPriceToText((double)row.Cells["TienVon"].Value) + ")", row.Cells["TienVon"].Value.ToString()!);

                // Replace placeholders in the Word document with the values from the DataGridView
                ReplaceWordPlaceholder(wordDoc, "SoBienNhan1", customerId);
                ReplaceWordPlaceholder(wordDoc, "SoBienNhan2", customerId);
                ReplaceWordPlaceholder(wordDoc, "LaiSuat1", productRate);
                ReplaceWordPlaceholder(wordDoc, "LaiSuat2", productRate);
                ReplaceWordPlaceholder(wordDoc, "TenKhachHang1", customerName);
                ReplaceWordPlaceholder(wordDoc, "TenKhachHang2", customerName);
                ReplaceWordPlaceholder(wordDoc, "DiaChi1", customerAddress);
                ReplaceWordPlaceholder(wordDoc, "DiaChi2", customerAddress);
                ReplaceWordPlaceholder(wordDoc, "LoaiTaiSan1", productRate);
                ReplaceWordPlaceholder(wordDoc, "LoaiTaiSan2", productRate);
                ReplaceWordPlaceholder(wordDoc, "TrongLuongVang1", productWeight);
                ReplaceWordPlaceholder(wordDoc, "TrongLuongVang2", productWeight);
                ReplaceWordPlaceholder(wordDoc, "TriGia1", productPrice);
                ReplaceWordPlaceholder(wordDoc, "TriGia2", productPrice);
                ReplaceWordPlaceholder(wordDoc, "TienVon1", productFund);
                ReplaceWordPlaceholder(wordDoc, "TienVon2", productFund);
            }

            // Save and close the Word document
            wordDoc.Save();
            wordDoc.Close();

            // Quit the Word application
            wordApp.Quit();
        }

        private void ReplaceWordPlaceholder(Word.Document doc, string placeholder, string newValue)
        {
            // Find the placeholder in the Word document
            if (doc.Bookmarks.Exists(placeholder))
            {
                Word.Bookmark bookmark = doc.Bookmarks[placeholder];
                Word.Range range = bookmark.Range;
                range.Text = newValue;
            }
            else
            {
                MessageBox.Show($"Bookmark '{placeholder}' does not exist in the document.");
            }
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
                string covertPriceToText = utility.ConvertPriceToText((double)cells[9].Value);
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