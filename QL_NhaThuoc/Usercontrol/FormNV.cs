using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_NhaThuoc.Usercontrol
{
    public partial class FormNV : UserControl
    {
        Phong fn = new Phong();
        SqlConnection conn = new SqlConnection();
        public string path = AppDomain.CurrentDomain.BaseDirectory;
        public FormNV()
        {
            InitializeComponent();
            this.VisibleChanged += MyUsercontrol_VisibleChanged;

        }

        private void MyUsercontrol_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                this.FormNV_Load(sender, e);
            }
        }

        private void FormNV_Load(object sender, EventArgs e)
        {
            roundedTextbox3._KeyPress += RoundedTextbox3_KeyPress;
            roundedTextbox5._KeyPress += RoundedTextbox5_KeyPress;
            fn.connection(conn);
            roundedTextbox1.Enabled = false;
            fn.LoadDataLNV(conn, dataGridView1,"");
            conn.Close();
            dataGridView1.ClearSelection();
            dataGridView1.CurrentCell = null;
        }

        private void RoundedTextbox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            fn.connection(conn);

            string s = roundedTextbox5.Texts;
            fn.LoadDataLNV(conn, dataGridView1, "select MaNV,TenNV,FORMAT(NgaySinh, 'yyyy-MM-dd') AS FormattedDate,GioiTinh,SDT,DIACHI,URL from NHAN_VIEN where TenNV like N'%" + s + "%' or sdt like '%"+s+"%'; ");
            conn.Close();

        }

        private void RoundedTextbox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Ví dụ: Chỉ cho phép nhập số
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ngăn nhập ký tự không phải số
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                roundedTextbox1.Texts = row.Cells["Column_ID"].Value.ToString();
                roundedTextbox2.Texts = row.Cells["Column_Name"].Value.ToString();
                roundedTextbox3.Texts = row.Cells["Column_Phone"].Value.ToString();
                roundedTextbox4.Texts = row.Cells["Column_Loc"].Value.ToString();
                DateTime NgaySinh = DateTime.Parse(row.Cells["Column_BDate"].Value.ToString());
                dateTimePicker1.Value = NgaySinh;
                if (comboBox1.Items.Contains(row.Cells["Column_Sex"].Value.ToString()))
                {
                    comboBox1.SelectedItem = row.Cells["Column_Sex"].Value.ToString();
                }
                string path = row.Cells["Column_URL"].Value.ToString();
                string file = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, path);
                if (path != "")
                {
                    if (pictureBox1.Image != null)
                    {
                        pictureBox1.Image.Dispose();
                        pictureBox1.Image = null;
                        file = row.Cells["Column_URL"].Value.ToString();
                        pictureBox1.Image = Image.FromFile(file);
                        pictureBox1.Tag = file; // Lưu đường dẫn vào thuộc tính Tag

                    }
                    else
                    {
                        file = row.Cells["Column_URL"].Value.ToString();
                        pictureBox1.Image = Image.FromFile(file);
                        pictureBox1.Tag = file; //
                    }

                }

            }


            roundedTextbox1.Enabled = false;
            roundedTextbox1.ForeColor = Color.Black;
        }

        private void Update_Click(object sender, EventArgs e)
        {
            fn.connection(conn);
            string url = pictureBox1.Tag as string;
            string MaNV = roundedTextbox1.Texts;
            string TenNV = roundedTextbox2.Texts;
            string SDT = roundedTextbox3.Texts;
            string DC = roundedTextbox4.Texts;
            DateTime NSinh = dateTimePicker1.Value;
            string Sex = comboBox1.Text;
            string query = "UPDATE Nhan_Vien SET TenNV = N'" + TenNV + "',  NgaySinh = '" + NSinh + "',    GioiTinh = N'" + Sex + "'  ,SDT = '"+SDT+ "',DiaChi = N'" + DC + "', URL= N'" + url + "'  WHERE MaNV = '" + MaNV + "';";
            SqlCommand cmd = new SqlCommand(query, conn);
            int rowsAffected = cmd.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                MessageBox.Show("Đã cập nhật thông tin nhân viên thành công!");
                
            }
            fn.LoadDataLNV(conn, dataGridView1,"");
            conn.Close();
        }

        private void Clear_Btn_Click(object sender, EventArgs e)
        {
            roundedTextbox1.Texts = "";
            roundedTextbox2.Texts = "";
            roundedTextbox3.Texts = "";
            roundedTextbox4.Texts = "";
            pictureBox1.Image = null;
      
        }


        private void Add_btn_click(object sender, EventArgs e)
        {

            string MaNV = fn.GetMaxIDNV(conn);
            fn.connection(conn);
            string url = pictureBox1.Tag as string;
            string TenNV = roundedTextbox2.Texts;
            string SDT = roundedTextbox3.Texts;
            string DC = roundedTextbox4.Texts;
            DateTime NSinh = dateTimePicker1.Value;
            string Sex = comboBox1.Text;
            string query = "INSERT INTO NHAN_VIEN values('" + MaNV + "',N'" + TenNV + "','" + NSinh + "',N'" + Sex + "','" + SDT + "',N'" + DC + "',N'" + url + "' );";
            SqlCommand cmd = new SqlCommand(query, conn);
            int rowsAffected1 = cmd.ExecuteNonQuery();
            if (rowsAffected1 > 0)
            {
                MessageBox.Show("Thêm nhân viên mới thành công");

            }
            fn.LoadDataLNV(conn, dataGridView1,"");
            conn.Close();
        }

        public void Load_btn_Click(object sender, EventArgs e)
        {
            if (roundedTextbox1.Texts != "")
            {
                string file = "";
                OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif", // Lọc định dạng ảnh
                    Title = "Chọn ảnh"
                };
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (pictureBox1.Image != null)
                    {
                        pictureBox1.Image.Dispose();
                        pictureBox1.Image = null;
                        file = openFileDialog.FileName;
                        pictureBox1.Image = Image.FromFile(file);
                        pictureBox1.Tag = file; // Lưu đường dẫn vào thuộc tính Tag

                    }
                    file = openFileDialog.FileName;
                    string imagesFolder = Path.Combine(path, "Image");
                    pictureBox1.Image = Image.FromFile(file);
                    // 
                    string targetPath = Path.Combine(imagesFolder, roundedTextbox1.Texts + ".jpg");
                    try
                    {
                        // Kiểm tra nếu thư mục đích không tồn tại thì tạo mới
                        if (!Directory.Exists(imagesFolder))
                        {
                            Directory.CreateDirectory(imagesFolder);
                        }

                        // Sao chép tệp và đổi tên
                        File.Copy(file, targetPath, true); // `true` để thay thế nếu tệp đã tồn tại
                        MessageBox.Show($"Đã đổi ảnh thành công");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi sao chép và đổi tên ảnh: " + ex.Message);
                    }
                    pictureBox1.Tag = @"Image\" + roundedTextbox1.Texts + ".jpg";
                }

            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên trước!!!!!!");
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void roundedButton5_Click(object sender, EventArgs e)
        {
            fn.connection(conn);
            string ma = roundedTextbox1.Texts;
            string sql = "delete from nhan_vien where manv = '" + ma + "';";
            SqlCommand cmd = new SqlCommand(sql, conn);
            int rows = cmd.ExecuteNonQuery();
            if (rows > 0)
            {
                MessageBox.Show("Đã xóa nhân viên!!!!!!");
            }
            fn.LoadDataLNV(conn, dataGridView1,"");
            conn.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

     

        private void roundedButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }
    }
}
