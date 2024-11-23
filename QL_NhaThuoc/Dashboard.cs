using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_NhaThuoc
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            formNV1.Visible = true;
            formToathuoc1.Visible = false;
            formKH1.Visible = false;
            pictureBox1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            formNV1.Visible = false;
            formToathuoc1.Visible = true;
            formKH1.Visible = false;
            pictureBox1.Visible = false;

        }

        private void Kh_Btn_Click(object sender, EventArgs e)
        {
            formNV1.Visible = false;
            formToathuoc1.Visible = false;
            formKH1.Visible = true;
            pictureBox1.Visible = false;

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            formNV1.Visible = false;
            formToathuoc1.Visible = false;
            formKH1.Visible = false;
            pictureBox1.Visible = true;

        }
    }
}
