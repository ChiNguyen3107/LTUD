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

namespace QL_NhaThuoc.Usercontrol
{
    public partial class FormNV : UserControl
    {
        Phong fn = new Phong();
        SqlConnection conn = new SqlConnection();
        public FormNV()
        {
            InitializeComponent();
        }

        private void FormNV_Load(object sender, EventArgs e)
        {
            fn.connection(conn);
            roundedTextbox1.Enabled = false;
            fn.LoadDataLNV(conn, dataGridView1);
            conn.Close();
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
                string file = row.Cells["Column_URL"].Value.ToString();
                if(file != "")
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
            fn.LoadDataLNV(conn, dataGridView1);
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
            fn.LoadDataLNV(conn, dataGridView1);
            conn.Close();
        }

        private void Load_btn_Click(object sender, EventArgs e)
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
                pictureBox1.Image = Image.FromFile(file);
                pictureBox1.Tag = file; // 

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
            fn.LoadDataLNV(conn, dataGridView1);
            conn.Close();
        }
    }
}
