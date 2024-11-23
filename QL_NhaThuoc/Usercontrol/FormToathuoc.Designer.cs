namespace QL_NhaThuoc
{
    partial class FormToathuoc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTenthuoc = new System.Windows.Forms.TextBox();
            this.textBoxLieuluong = new System.Windows.Forms.TextBox();
            this.buttonThem = new System.Windows.Forms.Button();
            this.buttonDatlai = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewToathuoc = new System.Windows.Forms.DataGridView();
            this.tenthuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donvi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lieuluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonDatlaitoathuoc = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDonvi = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxSoluong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonLHD = new System.Windows.Forms.Button();
            this.roundedTextbox5 = new QL_NhaThuoc.Usercontrol_Custome.RoundedTextbox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewToathuoc)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.White;
            this.listView1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(22, 46);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(395, 373);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(33, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên thuốc";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(462, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Liều lượng";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxTenthuoc
            // 
            this.textBoxTenthuoc.BackColor = System.Drawing.Color.White;
            this.textBoxTenthuoc.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTenthuoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(81)))), ((int)(((byte)(162)))));
            this.textBoxTenthuoc.Location = new System.Drawing.Point(142, 23);
            this.textBoxTenthuoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTenthuoc.Multiline = true;
            this.textBoxTenthuoc.Name = "textBoxTenthuoc";
            this.textBoxTenthuoc.Size = new System.Drawing.Size(227, 34);
            this.textBoxTenthuoc.TabIndex = 4;
            this.textBoxTenthuoc.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBoxLieuluong
            // 
            this.textBoxLieuluong.BackColor = System.Drawing.Color.White;
            this.textBoxLieuluong.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLieuluong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(81)))), ((int)(((byte)(162)))));
            this.textBoxLieuluong.Location = new System.Drawing.Point(575, 64);
            this.textBoxLieuluong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxLieuluong.Multiline = true;
            this.textBoxLieuluong.Name = "textBoxLieuluong";
            this.textBoxLieuluong.Size = new System.Drawing.Size(227, 34);
            this.textBoxLieuluong.TabIndex = 5;
            this.textBoxLieuluong.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // buttonThem
            // 
            this.buttonThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(81)))), ((int)(((byte)(162)))));
            this.buttonThem.FlatAppearance.BorderSize = 0;
            this.buttonThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonThem.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThem.ForeColor = System.Drawing.Color.White;
            this.buttonThem.Location = new System.Drawing.Point(859, 15);
            this.buttonThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(156, 29);
            this.buttonThem.TabIndex = 6;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = false;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // buttonDatlai
            // 
            this.buttonDatlai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(81)))), ((int)(((byte)(162)))));
            this.buttonDatlai.FlatAppearance.BorderSize = 0;
            this.buttonDatlai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDatlai.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDatlai.ForeColor = System.Drawing.Color.White;
            this.buttonDatlai.Location = new System.Drawing.Point(859, 58);
            this.buttonDatlai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDatlai.Name = "buttonDatlai";
            this.buttonDatlai.Size = new System.Drawing.Size(156, 29);
            this.buttonDatlai.TabIndex = 7;
            this.buttonDatlai.Text = "Đặt lại";
            this.buttonDatlai.UseVisualStyleBackColor = false;
            this.buttonDatlai.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewToathuoc);
            this.groupBox1.Controls.Add(this.buttonDatlaitoathuoc);
            this.groupBox1.Controls.Add(this.buttonXoa);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(429, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(704, 408);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Toa thuốc";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dataGridViewToathuoc
            // 
            this.dataGridViewToathuoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewToathuoc.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewToathuoc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewToathuoc.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewToathuoc.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(81)))), ((int)(((byte)(162)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(81)))), ((int)(((byte)(162)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewToathuoc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewToathuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewToathuoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenthuoc,
            this.donvi,
            this.soluong,
            this.lieuluong,
            this.dongia,
            this.thanhtien});
            this.dataGridViewToathuoc.Location = new System.Drawing.Point(6, 25);
            this.dataGridViewToathuoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewToathuoc.Name = "dataGridViewToathuoc";
            this.dataGridViewToathuoc.RowHeadersVisible = false;
            this.dataGridViewToathuoc.RowHeadersWidth = 62;
            this.dataGridViewToathuoc.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewToathuoc.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewToathuoc.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewToathuoc.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dataGridViewToathuoc.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewToathuoc.RowTemplate.Height = 28;
            this.dataGridViewToathuoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewToathuoc.Size = new System.Drawing.Size(692, 257);
            this.dataGridViewToathuoc.TabIndex = 0;
            this.dataGridViewToathuoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tenthuoc
            // 
            this.tenthuoc.HeaderText = "Tên thuốc";
            this.tenthuoc.MinimumWidth = 8;
            this.tenthuoc.Name = "tenthuoc";
            // 
            // donvi
            // 
            this.donvi.HeaderText = "Đơn vị";
            this.donvi.MinimumWidth = 8;
            this.donvi.Name = "donvi";
            // 
            // soluong
            // 
            this.soluong.HeaderText = "Số lượng";
            this.soluong.MinimumWidth = 8;
            this.soluong.Name = "soluong";
            // 
            // lieuluong
            // 
            this.lieuluong.HeaderText = "Liều lượng";
            this.lieuluong.MinimumWidth = 8;
            this.lieuluong.Name = "lieuluong";
            // 
            // dongia
            // 
            this.dongia.HeaderText = "Đơn giá";
            this.dongia.MinimumWidth = 8;
            this.dongia.Name = "dongia";
            // 
            // thanhtien
            // 
            this.thanhtien.HeaderText = "Thành tiền";
            this.thanhtien.MinimumWidth = 8;
            this.thanhtien.Name = "thanhtien";
            // 
            // buttonDatlaitoathuoc
            // 
            this.buttonDatlaitoathuoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(81)))), ((int)(((byte)(162)))));
            this.buttonDatlaitoathuoc.FlatAppearance.BorderSize = 0;
            this.buttonDatlaitoathuoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDatlaitoathuoc.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold);
            this.buttonDatlaitoathuoc.ForeColor = System.Drawing.Color.White;
            this.buttonDatlaitoathuoc.Location = new System.Drawing.Point(496, 303);
            this.buttonDatlaitoathuoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDatlaitoathuoc.Name = "buttonDatlaitoathuoc";
            this.buttonDatlaitoathuoc.Size = new System.Drawing.Size(165, 28);
            this.buttonDatlaitoathuoc.TabIndex = 6;
            this.buttonDatlaitoathuoc.Text = "Đặt lại toa thuốc";
            this.buttonDatlaitoathuoc.UseVisualStyleBackColor = false;
            this.buttonDatlaitoathuoc.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonXoa
            // 
            this.buttonXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(81)))), ((int)(((byte)(162)))));
            this.buttonXoa.FlatAppearance.BorderSize = 0;
            this.buttonXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonXoa.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXoa.ForeColor = System.Drawing.Color.White;
            this.buttonXoa.Location = new System.Drawing.Point(346, 303);
            this.buttonXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(144, 28);
            this.buttonXoa.TabIndex = 6;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = false;
            this.buttonXoa.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(33, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Đơn vị";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBoxDonvi
            // 
            this.textBoxDonvi.BackColor = System.Drawing.Color.White;
            this.textBoxDonvi.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDonvi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(81)))), ((int)(((byte)(162)))));
            this.textBoxDonvi.Location = new System.Drawing.Point(142, 64);
            this.textBoxDonvi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxDonvi.Multiline = true;
            this.textBoxDonvi.Name = "textBoxDonvi";
            this.textBoxDonvi.Size = new System.Drawing.Size(227, 34);
            this.textBoxDonvi.TabIndex = 10;
            this.textBoxDonvi.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxSoluong);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.buttonLHD);
            this.groupBox2.Controls.Add(this.textBoxTenthuoc);
            this.groupBox2.Controls.Add(this.textBoxDonvi);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBoxLieuluong);
            this.groupBox2.Controls.Add(this.buttonDatlai);
            this.groupBox2.Controls.Add(this.buttonThem);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(22, 452);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(1086, 136);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin thuốc";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // textBoxSoluong
            // 
            this.textBoxSoluong.BackColor = System.Drawing.Color.White;
            this.textBoxSoluong.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSoluong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(81)))), ((int)(((byte)(162)))));
            this.textBoxSoluong.Location = new System.Drawing.Point(575, 26);
            this.textBoxSoluong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSoluong.Multiline = true;
            this.textBoxSoluong.Name = "textBoxSoluong";
            this.textBoxSoluong.Size = new System.Drawing.Size(227, 34);
            this.textBoxSoluong.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(462, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Số lượng";
            // 
            // buttonLHD
            // 
            this.buttonLHD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(81)))), ((int)(((byte)(162)))));
            this.buttonLHD.FlatAppearance.BorderSize = 0;
            this.buttonLHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLHD.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLHD.ForeColor = System.Drawing.Color.White;
            this.buttonLHD.Location = new System.Drawing.Point(859, 98);
            this.buttonLHD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLHD.Name = "buttonLHD";
            this.buttonLHD.Size = new System.Drawing.Size(156, 29);
            this.buttonLHD.TabIndex = 11;
            this.buttonLHD.Text = "Lập hóa đơn";
            this.buttonLHD.UseVisualStyleBackColor = false;
            this.buttonLHD.Click += new System.EventHandler(this.buttonLHD_Click);
            // 
            // roundedTextbox5
            // 
            this.roundedTextbox5.BackColor = System.Drawing.Color.White;
            this.roundedTextbox5.BorderColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(94)))), ((int)(((byte)(215)))));
            this.roundedTextbox5.BorderSize1 = 1;
            this.roundedTextbox5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedTextbox5.IsPlaceholder = true;
            this.roundedTextbox5.Location = new System.Drawing.Point(22, 11);
            this.roundedTextbox5.Multiline = false;
            this.roundedTextbox5.Name = "roundedTextbox5";
            this.roundedTextbox5.Padding = new System.Windows.Forms.Padding(10, 7, 10, 3);
            this.roundedTextbox5.PasswordChar = false;
            this.roundedTextbox5.PlaceholderColor1 = System.Drawing.Color.Black;
            this.roundedTextbox5.PlaceholderText1 = "Tìm kiếm";
            this.roundedTextbox5.Size = new System.Drawing.Size(395, 30);
            this.roundedTextbox5.TabIndex = 14;
            this.roundedTextbox5.Texts = "";
            this.roundedTextbox5.UnderLineStyle1 = true;
            // 
            // FormToathuoc
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.roundedTextbox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormToathuoc";
            this.Size = new System.Drawing.Size(1147, 720);
            this.Load += new System.EventHandler(this.FormToathuoc_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewToathuoc)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTenthuoc;
        private System.Windows.Forms.TextBox textBoxLieuluong;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.Button buttonDatlai;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewToathuoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDonvi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonDatlaitoathuoc;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button buttonLHD;
        private System.Windows.Forms.TextBox textBoxSoluong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenthuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn donvi;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn lieuluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn dongia;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhtien;
        private Usercontrol_Custome.RoundedTextbox roundedTextbox5;
    }
}