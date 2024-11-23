using QL_NhaThuoc.Usercontrol_Custome;
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
    public partial class FormKH : UserControl
    {

        Dat fn = new Dat();
        SqlConnection conn = new SqlConnection();
        public FormKH()
        {
            InitializeComponent();
            this.VisibleChanged += MyUsercontrol_VisibleChanged;

        }

        private void MyUsercontrol_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                this.FormKH_Load(sender, e);
            }
        }

        private void FormKH_Load(object sender, EventArgs e)
        {
            roundedTextbox3._KeyPress += RoundedTextbox3_KeyPress;
            roundedTextbox5._KeyPress += RoundedTextbox5_KeyPress;

            fn.connection(conn);
            fn.LoadKH(conn, dataGridView1,"");
            conn.Close();
            dataGridView1.ClearSelection();
            dataGridView1.CurrentCell = null;
        }

        private void RoundedTextbox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            fn.connection(conn);

            string s = roundedTextbox5.Texts;
            fn.LoadKH(conn, dataGridView1, "select MAKH,MAHD,TENKH,SDT,GIOITINH  from KHACH_HANG where tenkh like '%"+s+"%' or sdt like '%"+s+"%';");
            conn.Close();
        }

        private void RoundedTextbox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ngăn nhập ký tự không phải số
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                roundedTextbox1.Texts = row.Cells["Column_ID"].Value.ToString();
                roundedTextbox2.Texts = row.Cells["Column_Name"].Value.ToString();
                roundedTextbox3.Texts = row.Cells["Column_Phone"].Value.ToString();
                if (comboBox1.Items.Contains(row.Cells["Column_Sex"].Value.ToString()))
                {
                    comboBox1.SelectedItem = row.Cells["Column_Sex"].Value.ToString();
                }
            }

            roundedTextbox1.Enabled = false;
            roundedTextbox1.ForeColor = Color.Black;
        }

        private void Update_kh_CLick(object sender, EventArgs e)
        {
            fn.connection(conn);
            string MaNV = roundedTextbox1.Texts;
            string TenNV = roundedTextbox2.Texts;
            string SDT = roundedTextbox3.Texts;
            string Sex = comboBox1.Text;
            string query = "UPDATE khach_hang SET TenKH = N'" + TenNV + "', GioiTinh = N'" + Sex + "'  ,SDT = '" + SDT + "'  WHERE MaKH = '" + MaNV + "';";
            SqlCommand cmd = new SqlCommand(query, conn);
            int rowsAffected = cmd.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                MessageBox.Show("Đã cập nhật thông tin nhân viên thành công!");

            }
            fn.LoadKH(conn, dataGridView1, "");
            conn.Close();
        }

        private void Clear_kh_Click(object sender, EventArgs e)
        {

            roundedTextbox1.Texts = "";
            roundedTextbox2.Texts = "";
            roundedTextbox3.Texts = "";
        }
    }

         
}
