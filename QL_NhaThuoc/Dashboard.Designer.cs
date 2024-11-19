namespace QL_NhaThuoc
{
    partial class Dashboard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.NV_Btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.formNV1 = new QL_NhaThuoc.Usercontrol.FormNV();
            this.formToathuoc1 = new QL_NhaThuoc.FormToathuoc();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(229)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.NV_Btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(276, 720);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(276, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "Nhân Viên";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(0, 182);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(276, 45);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // NV_Btn
            // 
            this.NV_Btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.NV_Btn.FlatAppearance.BorderSize = 2;
            this.NV_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NV_Btn.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NV_Btn.ForeColor = System.Drawing.Color.White;
            this.NV_Btn.Location = new System.Drawing.Point(0, 233);
            this.NV_Btn.Name = "NV_Btn";
            this.NV_Btn.Size = new System.Drawing.Size(276, 45);
            this.NV_Btn.TabIndex = 1;
            this.NV_Btn.Text = "Khách Hàng";
            this.NV_Btn.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.formNV1);
            this.panel2.Controls.Add(this.formToathuoc1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(276, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1147, 720);
            this.panel2.TabIndex = 1;
            // 
            // formNV1
            // 
            this.formNV1.BackColor = System.Drawing.Color.White;
            this.formNV1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formNV1.Location = new System.Drawing.Point(0, 0);
            this.formNV1.Name = "formNV1";
            this.formNV1.Size = new System.Drawing.Size(1147, 720);
            this.formNV1.TabIndex = 1;
            // 
            // formToathuoc1
            // 
            this.formToathuoc1.BackColor = System.Drawing.Color.White;
            this.formToathuoc1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formToathuoc1.Location = new System.Drawing.Point(0, 0);
            this.formToathuoc1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.formToathuoc1.Name = "formToathuoc1";
            this.formToathuoc1.Size = new System.Drawing.Size(1147, 720);
            this.formToathuoc1.TabIndex = 0;
            // 
            // Dashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1423, 720);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button NV_Btn;
        private System.Windows.Forms.Panel panel2;
        private FormToathuoc formToathuoc1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private Usercontrol.FormNV formNV1;
    }
}