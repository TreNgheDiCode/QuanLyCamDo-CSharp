using System.Data.OleDb;
using System.Globalization;
using System.IO;
using System.Reflection;

namespace QuanLyCamDo
{
    public partial class MainForm : Form
    {
        private static OleDbConnection connection = null!;

        public static OleDbConnection Conn { get { return connection; } set { connection = value; } }

        public MainForm()
        {
            InitializeComponent();
            CenterToScreen();
            ControlBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;

            if (connection == null)
            {
                AssignDatabase();
            }
        }

        public static void AssignDatabase()
        {
            var currentPath = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            var isAccess = Directory.EnumerateFiles(currentPath, "*.accdb", SearchOption.TopDirectoryOnly).Any();

            if (isAccess)
            {
                currentPath = Directory.EnumerateFiles(currentPath, "*.accdb", SearchOption.TopDirectoryOnly).First();
                connection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={currentPath};Persist Security Info=False;");
            }
            else
            {
                MessageBox.Show("Vui lòng đặt file dữ liệu hợp lệ vào cùng thư mục trước khi sử dụng", "File dữ liệu không tồn tại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
            CenterLocation();
        }

        private void CenterLocation()
        {
            int centerX = Size.Width / 2;
            lbSubCompany.Location = new Point(centerX - lbSubCompany.Width / 2, lbSubCompany.Location.Y);
            lbCompanyName.Location = new Point(centerX - lbCompanyName.Width / 2, lbCompanyName.Location.Y);
            lbApp.Location = new Point(centerX - lbApp.Width / 2, lbApp.Location.Y);
            lbTitle.Location = new Point(centerX - lbTitle.Width / 2, lbTitle.Location.Y);
            lbCurrentTime.Location = new Point(centerX - lbCurrentTime.Width / 2, lbCurrentTime.Location.Y);
        }
        private void lbAddCustomer_Click(object sender, EventArgs e)
        {
            AddCustomerForm addCustomerForm = new();
            addCustomerForm.ShowDialog();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CultureInfo vn = CultureInfo.GetCultureInfo("vi-VN");
            lbCurrentTime.Text = "Hôm nay, " + DateTime.Now.ToString("D", vn) + ". Vào lúc " + DateTime.Now.ToLongTimeString();
            CenterLocation();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnExtendCustomer_Click(object sender, EventArgs e)
        {
            SearchCustomerByIdForm searchCustomerByIdForm = new();
            searchCustomerByIdForm.ShowDialog();
        }

        private void btnRedeemCustomer_Click(object sender, EventArgs e)
        {
            SearchCustomerByIdForm searchCustomerByIdForm = new();
            searchCustomerByIdForm.FormType = "redeem";
            searchCustomerByIdForm.ShowDialog();
        }

        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            SearchCustomerForm searchCustomerForm = new();
            searchCustomerForm.ShowDialog();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new();
            settingsForm.ShowDialog();
        }
    }
}
