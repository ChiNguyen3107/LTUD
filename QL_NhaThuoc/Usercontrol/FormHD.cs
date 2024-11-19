using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace QL_NhaThuoc
{
    public partial class FormHD : UserControl
    {
        public FormHD()
        {
            InitializeComponent();
        }
        private nguyen db = new nguyen();

        public void LoadDataFromToaThuoc(DataTable data)
        {
            foreach (DataRow row in data.Rows)
            {
                dataGridView1.Rows.Add(row["tenthuoc"], row["donvi"], row["soluong"], row["lieuluong"], row["dongia"], row["thanhtien"]);
            }
            TongCong();
        }

        private void TongCong()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["thanhtien"].Value != null && decimal.TryParse(row.Cells["thanhtien"].Value.ToString(), out decimal thanhTien))
                {
                    total += thanhTien;
                }
            }

            // Gán tổng vào textBoxtongcong
            textBoxtongcong.Text = total.ToString("N2");
        }

        private string GenerateCustomerID()
        {
            string newID = "KH0001";
            string query = "SELECT TOP 1 MAKH FROM KHACH_HANG ORDER BY MAKH DESC";

            using (SqlConnection conn = db.ketnoi())
            {
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    var result = command.ExecuteScalar();
                    if (result != null)
                    {
                        string lastID = result.ToString();
                        int number = int.Parse(lastID.Substring(2)) + 1;
                        newID = "KH" + number.ToString("D4"); // "D4" để giữ định dạng 4 chữ số
                    }
                }
            }
            return newID;
        }

        private string SaveCustomer(string name, string phone)
        {
            string customerID = GenerateCustomerID();
            string query = "INSERT INTO KHACH_HANG (MAKH, TENKH, SDT) VALUES (@MAKH, @TENKH, @SDT)";

            using (SqlConnection conn = db.ketnoi())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MAKH", customerID);
                    cmd.Parameters.AddWithValue("@TENKH", name);
                    cmd.Parameters.AddWithValue("@SDT", phone);

                    cmd.ExecuteNonQuery();
                }
            }
            return customerID;
        }

        private string GenerateInvoiceID()
        {
            string newInvoiceID = "HD00001";
            string query = "SELECT TOP 1 MAHD FROM HOA_DON ORDER BY MAHD DESC";

            using (SqlConnection conn = db.ketnoi())
            {
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    var result = command.ExecuteScalar();
                    if (result != null)
                    {
                        string lastInvoiceID = result.ToString();
                        int number = int.Parse(lastInvoiceID.Substring(2)) + 1;
                        newInvoiceID = "HD" + number.ToString("D5"); // "D5" giữ định dạng 5 chữ số
                    }
                }
            }
            return newInvoiceID;
        }


        private int SaveInvoice(string invoiceID, string customerId, decimal totalAmount, string employeeId)
        {
            string query = "INSERT INTO HOA_DON (MAHD, MAKH, TONGTIEN, NGAYLAP, MANV) VALUES (@invoiceID, @customerId, @totalAmount, @date, @employeeId)";
            using (SqlConnection conn = db.ketnoi())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@invoiceID", invoiceID);
                    cmd.Parameters.AddWithValue("@customerId", customerId);
                    cmd.Parameters.AddWithValue("@totalAmount", totalAmount);
                    cmd.Parameters.AddWithValue("@date", DateTime.Now);
                    cmd.Parameters.AddWithValue("@employeeId", employeeId);

                    cmd.ExecuteNonQuery();
                    return 0; // Không cần thiết phải lấy SCOPE_IDENTITY() vì bạn đã tự tạo mã hóa đơn
                }
            }
        }


        private void SaveInvoiceDetails(string invoiceId, DataGridView dataGridView)
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Cells["tenthuoc"].Value != null)
                {
                    string medicineName = row.Cells["tenthuoc"].Value.ToString();
                    int quantity = Convert.ToInt32(row.Cells["soluong"].Value);
                    string dosage = row.Cells["lieuluong"].Value?.ToString(); // Lấy liều lượng từ DataGridView

                    // Lấy ID thuốc từ cơ sở dữ liệu
                    string medicineId = GetMedicineId(medicineName);

                    string query = "INSERT INTO CT_HOA_DON (MAHD, MATHUOC, SOLUONG, LIEULUONG) " +
                                   "VALUES (@invoiceId, @medicineId, @quantity, @lieuluong)";
                    using (SqlConnection conn = db.ketnoi())
                    {
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@invoiceId", invoiceId);
                            cmd.Parameters.AddWithValue("@medicineId", medicineId);
                            cmd.Parameters.AddWithValue("@quantity", quantity);
                            cmd.Parameters.AddWithValue("@lieuluong", string.IsNullOrEmpty(dosage) ? DBNull.Value : (object)dosage);

                            cmd.ExecuteNonQuery();
                        }
                    }
                }
            }
        }

        private string GetMedicineId(string medicineName)
        {
            string medicineId = null; // Mặc định là null nếu không tìm thấy thuốc
            string query = "SELECT MATHUOC FROM THUOC WHERE TENTHUOC = @medicineName";

            using (SqlConnection conn = db.ketnoi())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@medicineName", medicineName);
                    object result = cmd.ExecuteScalar(); // Thực thi và lấy giá trị đầu tiên từ kết quả truy vấn

                    if (result != null)
                    {
                        medicineId = result.ToString();
                    }
                }
            }

            return medicineId;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        /*private void Form1_Load(object sender, EventArgs e)
        {
            textBox3.Text = GenerateInvoiceID();
            textBox3.ReadOnly = true;
            LoadComboBox();
        }*/

        private void LoadComboBox()
        {
            nguyen cn = new nguyen(); // Tạo đối tượng nguyen
            DataTable data = cn.LayDuLieuNV(); // Lấy dữ liệu từ bảng NHAN_VIEN

            comboBox1.DisplayMember = "TENNV"; // Hiển thị tên nhân viên
            comboBox1.ValueMember = "MANV"; // Lưu mã nhân viên
            comboBox1.DataSource = data; // Đổ dữ liệu vào ComboBox
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Kiểm tra đầu vào
            string customerName = textBoxTenKH.Text.Trim();
            string customerPhone = textBoxSDT.Text.Trim();

            if (string.IsNullOrEmpty(customerName) || string.IsNullOrEmpty(customerPhone))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin khách hàng.");
                return;
            }

            if (!Regex.IsMatch(customerPhone, @"^\d{10}$")) // Kiểm tra số điện thoại có 10 chữ số
            {
                MessageBox.Show("Số điện thoại không hợp lệ. Vui lòng nhập lại.");
                return;
            }

            // Kiểm tra nếu người dùng chưa chọn nhân viên từ comboBox
            if (comboBox1.SelectedValue == null || comboBox1.SelectedValue == DBNull.Value)
            {
                MessageBox.Show("Vui lòng chọn nhân viên.");
                return;
            }

            try
            {
                // Kiểm tra số điện thoại đã tồn tại trong bảng KHACH_HANG
                string customerId = GetCustomerIdByPhone(customerPhone);

                if (string.IsNullOrEmpty(customerId))
                {
                    // Nếu không tồn tại, thêm khách hàng mới
                    customerId = SaveCustomer(customerName, customerPhone);
                }

                // Lưu hóa đơn
                string newInvoiceID = GenerateInvoiceID();
                textBox3.Text = newInvoiceID; // Hiển thị mã hóa đơn vào textBox3

                // Lấy mã nhân viên từ ComboBox
                string employeeId = comboBox1.SelectedValue.ToString(); // Lấy MANV từ ComboBox

                if (decimal.TryParse(textBoxtongcong.Text, out decimal totalAmount))
                {
                    int invoiceId = SaveInvoice(newInvoiceID, customerId, totalAmount, employeeId);

                    // Lưu chi tiết hóa đơn
                    SaveInvoiceDetails(newInvoiceID, dataGridView1);

                    MessageBox.Show("Thanh toán thành công!");

                    // Tắt form HD và chuyển về form ToaThuoc
                    this.Hide(); // Ẩn form HD

                    FormToathuoc formToaThuoc = new FormToathuoc();
                    formToaThuoc.Show(); // Hiển thị form ToaThuoc
                }
                else
                {
                    MessageBox.Show("Tổng tiền không hợp lệ.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }

        // Phương thức kiểm tra số điện thoại trong bảng KHACH_HANG
        private string GetCustomerIdByPhone(string phone)
        {
            string customerId = null;
            string query = "SELECT MAKH FROM KHACH_HANG WHERE SDT = @SDT";

            using (SqlConnection conn = db.ketnoi())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@SDT", phone);
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        customerId = result.ToString();
                    }
                }
            }

            return customerId;
        }



        private void textBoxtongcong_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxNV_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void FormHD_Load(object sender, EventArgs e)
        {
            textBox3.Text = GenerateInvoiceID();
            textBox3.ReadOnly = true;
            LoadComboBox();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
