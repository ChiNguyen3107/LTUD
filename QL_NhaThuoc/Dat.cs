using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_NhaThuoc
{
    internal class Dat
    {
        public void connection(SqlConnection conn)
        {
            conn.ConnectionString = "Server = MSI; Database = QuanLyThuoc;Integrated Security=True";
            conn.Open();
        }

        public void LoadKH(SqlConnection conn, DataGridView dataGridView1, string sql)
        {
            if(sql== "")
            {
                sql = " select MAKH,MAHD,TENKH,SDT,GIOITINH  from KHACH_HANG; ";
                SqlCommand cmd = new SqlCommand(sql, conn);
                dataGridView1.Rows.Clear();
                try
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        int rowindex = dataGridView1.Rows.Add();
                        DataGridViewRow row = dataGridView1.Rows[rowindex];
                        row.Cells["Column_ID"].Value = reader["MAKH"];
                        row.Cells["Column_Name"].Value = reader["TENKH"];
                        row.Cells["Column_Sex"].Value = reader["GIOITINH"];
                        row.Cells["Column_Phone"].Value = reader["SDT"];
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                dataGridView1.Rows.Clear();
                try
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        int rowindex = dataGridView1.Rows.Add();
                        DataGridViewRow row = dataGridView1.Rows[rowindex];
                        row.Cells["Column_ID"].Value = reader["MAKH"];
                        row.Cells["Column_Name"].Value = reader["TENKH"];
                        row.Cells["Column_Sex"].Value = reader["GIOITINH"];
                        row.Cells["Column_Phone"].Value = reader["SDT"];
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
           
        }
    }
}
