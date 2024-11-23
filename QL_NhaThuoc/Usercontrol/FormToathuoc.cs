using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_NhaThuoc
{
    public partial class FormToathuoc : UserControl
    {
        private nguyen db = new nguyen(); // Đối tượng để kết nối cơ sở dữ liệu
        public FormToathuoc()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                // Lấy mục được chọn trong listView1
                ListViewItem selectedItem = listView1.SelectedItems[0];

                // Điền các giá trị từ listView vào các TextBox trong groupBox2
                textBoxTenthuoc.Text = selectedItem.SubItems[1].Text;
                textBoxDonvi.Text = selectedItem.SubItems[3].Text;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void LoadDataToListView(string query)
        {
            listView1.Items.Clear(); // Xóa dữ liệu cũ trong ListView

            // Cấu hình ListView
            listView1.View = View.Details;
            listView1.Columns.Clear();
            listView1.Columns.Add("Mã Thuốc", 80);
            listView1.Columns.Add("Tên Thuốc", 150);
            listView1.Columns.Add("Đơn Giá", 100);
            listView1.Columns.Add("Đơn Vị", 100);
            if (query == "")
            {
                try
                {
                    using (SqlConnection conn = db.ketnoi())
                    {
                        query = "SELECT MATHUOC, TENTHUOC, DONGIA, DONVI FROM THUOC";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(reader["MATHUOC"].ToString());
                            item.SubItems.Add(reader["TENTHUOC"].ToString());
                            item.SubItems.Add(reader["DONGIA"].ToString());
                            item.SubItems.Add(reader["DONVI"].ToString());

                            listView1.Items.Add(item);
                        }
                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
                }
            }
            else
            {
                try
                {
                    using (SqlConnection conn = db.ketnoi())
                    {
                        
                        SqlCommand cmd = new SqlCommand(query, conn);
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(reader["MATHUOC"].ToString());
                            item.SubItems.Add(reader["TENTHUOC"].ToString());
                            item.SubItems.Add(reader["DONGIA"].ToString());
                            item.SubItems.Add(reader["DONVI"].ToString());

                            listView1.Items.Add(item);
                        }
                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
                }
            }
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các TextBox trong groupBox2
            string tenThuoc = textBoxTenthuoc.Text;
            string donVi = textBoxDonvi.Text;
            string lieuLuong = textBoxLieuluong.Text;
            int soLuong = 0;

            // Kiểm tra dữ liệu hợp lệ trước khi thêm
            if (string.IsNullOrWhiteSpace(tenThuoc) || string.IsNullOrWhiteSpace(donVi) || string.IsNullOrWhiteSpace(lieuLuong))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin trước khi thêm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra xem có mục nào được chọn trong listView1 không
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một loại thuốc trong danh sách.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy số lượng từ textbox
            if (!int.TryParse(textBoxSoluong.Text, out soLuong))
            {
                MessageBox.Show("Số lượng không hợp lệ. Vui lòng nhập số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy đơn giá từ mục được chọn trong ListView
            string donGiaText = listView1.SelectedItems[0].SubItems[2].Text;
            if (!decimal.TryParse(donGiaText, out decimal donGia))
            {
                MessageBox.Show("Đơn giá không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tính thành tiền
            decimal thanhTien = soLuong * donGia;

            // Thêm một hàng vào dataGridViewToathuoc
            dataGridViewToathuoc.Rows.Add(tenThuoc, donVi, soLuong, lieuLuong, donGia, thanhTien);

            // Xóa dữ liệu sau khi thêm
            textBoxTenthuoc.Clear();
            textBoxDonvi.Clear();
            textBoxLieuluong.Clear();
            textBoxSoluong.Clear();
        }




        private void button2_Click(object sender, EventArgs e)
        {
            textBoxTenthuoc.Clear();
            textBoxDonvi.Clear();
            textBoxLieuluong.Clear();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng nào được chọn trong dataGridViewToathuoc không
            if (dataGridViewToathuoc.SelectedRows.Count > 0)
            {
                // Xóa hàng được chọn đầu tiên trong danh sách các hàng đã chọn
                dataGridViewToathuoc.Rows.RemoveAt(dataGridViewToathuoc.SelectedRows[0].Index);
            }
            else
            {
                // Thông báo nếu không có hàng nào được chọn
                MessageBox.Show("Vui lòng chọn một hàng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Xóa tất cả các hàng trong dataGridViewToathuoc
            dataGridViewToathuoc.Rows.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonLHD_Click(object sender, EventArgs e)
        {
            FormHD formHD = new FormHD();

            // Tạo DataTable và thêm các cột cần thiết
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("tenthuoc");
            dataTable.Columns.Add("donvi");
            dataTable.Columns.Add("soluong");
            dataTable.Columns.Add("lieuluong");
            dataTable.Columns.Add("dongia");
            dataTable.Columns.Add("thanhtien");  // Thêm cột 'thanhtien' nếu cần thiết

            // Thêm dữ liệu từ DataGridView của FormToathuoc vào DataTable
            foreach (DataGridViewRow row in dataGridViewToathuoc.Rows)
            {
                // Bỏ qua hàng mới
                if (row.IsNewRow) continue;

                // Tạo một DataRow mới
                DataRow dataRow = dataTable.NewRow();

                // Kiểm tra và gán giá trị cho từng cột
                dataRow["tenthuoc"] = row.Cells[0].Value ?? DBNull.Value;
                dataRow["donvi"] = row.Cells[1].Value ?? DBNull.Value;
                dataRow["soluong"] = row.Cells[2].Value ?? DBNull.Value;
                dataRow["lieuluong"] = row.Cells[3].Value ?? DBNull.Value;
                dataRow["dongia"] = row.Cells[4].Value ?? DBNull.Value;

                // Nếu cột 'thanhtien' tồn tại trong DataGridView, thêm vào DataTable
                if (row.Cells.Count > 5 && row.Cells[5].Value != null)
                {
                    dataRow["thanhtien"] = row.Cells[5].Value;
                }
                else
                {
                    dataRow["thanhtien"] = DBNull.Value;
                }

                // Thêm hàng vào DataTable
                dataTable.Rows.Add(dataRow);
            }

            // Truyền dữ liệu sang formHD
            formHD.LoadDataFromToaThuoc(dataTable);

            // Hiển thị formHD
            if (!this.Controls.Contains(formHD))
            {
                this.Controls.Add(formHD);
                formHD.Dock = DockStyle.Fill; // Tùy chỉnh dock
            }
            formHD.BringToFront();
        }

        private void FormToathuoc_Load(object sender, EventArgs e)
        {
            LoadDataToListView("");
            roundedTextbox5._KeyPress += RoundedTextbox5__KeyPress;
        }

        private void RoundedTextbox5__KeyPress(object sender, KeyPressEventArgs e)
        {
            string s = roundedTextbox5.Texts;
            LoadDataToListView("SELECT MATHUOC, TENTHUOC, DONGIA, DONVI FROM THUOC where tenthuoc like '%"+s+"%'");
        }
    }
}
