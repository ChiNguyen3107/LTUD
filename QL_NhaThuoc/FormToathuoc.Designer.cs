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
            this.listView1 = new System.Windows.Forms.ListView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTenthuoc = new System.Windows.Forms.TextBox();
            this.textBoxLieuluong = new System.Windows.Forms.TextBox();
            this.buttonThem = new System.Windows.Forms.Button();
            this.buttonDatlai = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewToathuoc = new System.Windows.Forms.DataGridView();
            this.buttonDatlaitoathuoc = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDonvi = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonLHD = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSoluong = new System.Windows.Forms.TextBox();
            this.tenthuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donvi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lieuluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewToathuoc)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 65);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(344, 376);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(344, 47);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(37, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên thuốc";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(520, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Liều lượng";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxTenthuoc
            // 
            this.textBoxTenthuoc.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxTenthuoc.Location = new System.Drawing.Point(160, 33);
            this.textBoxTenthuoc.Multiline = true;
            this.textBoxTenthuoc.Name = "textBoxTenthuoc";
            this.textBoxTenthuoc.Size = new System.Drawing.Size(255, 41);
            this.textBoxTenthuoc.TabIndex = 4;
            this.textBoxTenthuoc.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBoxLieuluong
            // 
            this.textBoxLieuluong.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxLieuluong.Location = new System.Drawing.Point(647, 140);
            this.textBoxLieuluong.Multiline = true;
            this.textBoxLieuluong.Name = "textBoxLieuluong";
            this.textBoxLieuluong.Size = new System.Drawing.Size(255, 41);
            this.textBoxLieuluong.TabIndex = 5;
            this.textBoxLieuluong.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // buttonThem
            // 
            this.buttonThem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThem.Location = new System.Drawing.Point(964, 16);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(176, 58);
            this.buttonThem.TabIndex = 6;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = false;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // buttonDatlai
            // 
            this.buttonDatlai.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonDatlai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDatlai.Location = new System.Drawing.Point(964, 91);
            this.buttonDatlai.Name = "buttonDatlai";
            this.buttonDatlai.Size = new System.Drawing.Size(176, 58);
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
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(402, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(750, 429);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Toa thuốc";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dataGridViewToathuoc
            // 
            this.dataGridViewToathuoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewToathuoc.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewToathuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewToathuoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenthuoc,
            this.donvi,
            this.soluong,
            this.lieuluong,
            this.dongia,
            this.thanhtien});
            this.dataGridViewToathuoc.Location = new System.Drawing.Point(0, 53);
            this.dataGridViewToathuoc.Name = "dataGridViewToathuoc";
            this.dataGridViewToathuoc.RowHeadersWidth = 62;
            this.dataGridViewToathuoc.RowTemplate.Height = 28;
            this.dataGridViewToathuoc.Size = new System.Drawing.Size(750, 321);
            this.dataGridViewToathuoc.TabIndex = 0;
            this.dataGridViewToathuoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // buttonDatlaitoathuoc
            // 
            this.buttonDatlaitoathuoc.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonDatlaitoathuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDatlaitoathuoc.Location = new System.Drawing.Point(505, 371);
            this.buttonDatlaitoathuoc.Name = "buttonDatlaitoathuoc";
            this.buttonDatlaitoathuoc.Size = new System.Drawing.Size(245, 58);
            this.buttonDatlaitoathuoc.TabIndex = 6;
            this.buttonDatlaitoathuoc.Text = "Đặt lại toa thuốc";
            this.buttonDatlaitoathuoc.UseVisualStyleBackColor = false;
            this.buttonDatlaitoathuoc.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonXoa
            // 
            this.buttonXoa.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXoa.Location = new System.Drawing.Point(323, 371);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(176, 58);
            this.buttonXoa.TabIndex = 6;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = false;
            this.buttonXoa.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(37, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Đơn vị";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBoxDonvi
            // 
            this.textBoxDonvi.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxDonvi.Location = new System.Drawing.Point(160, 140);
            this.textBoxDonvi.Multiline = true;
            this.textBoxDonvi.Name = "textBoxDonvi";
            this.textBoxDonvi.Size = new System.Drawing.Size(255, 41);
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
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 444);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1140, 223);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin thuốc";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // buttonLHD
            // 
            this.buttonLHD.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonLHD.Location = new System.Drawing.Point(964, 165);
            this.buttonLHD.Name = "buttonLHD";
            this.buttonLHD.Size = new System.Drawing.Size(176, 58);
            this.buttonLHD.TabIndex = 11;
            this.buttonLHD.Text = "Lập hóa đơn";
            this.buttonLHD.UseVisualStyleBackColor = false;
            this.buttonLHD.Click += new System.EventHandler(this.buttonLHD_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label4.Location = new System.Drawing.Point(520, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Số lượng";
            // 
            // textBoxSoluong
            // 
            this.textBoxSoluong.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxSoluong.Location = new System.Drawing.Point(647, 33);
            this.textBoxSoluong.Multiline = true;
            this.textBoxSoluong.Name = "textBoxSoluong";
            this.textBoxSoluong.Size = new System.Drawing.Size(255, 41);
            this.textBoxSoluong.TabIndex = 13;
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
            // FormToathuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1164, 689);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listView1);
            this.Name = "FormToathuoc";
            this.Text = "FormToathuoc";
            this.Load += new System.EventHandler(this.FormToathuoc_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewToathuoc)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox textBox1;
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
    }
}