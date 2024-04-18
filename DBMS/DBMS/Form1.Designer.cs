namespace DBMS
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_diaChi = new System.Windows.Forms.TextBox();
            this.tb_tenLoaiSanPham = new System.Windows.Forms.TextBox();
            this.tb_tenNCC = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bt_Search = new System.Windows.Forms.Button();
            this.bt_Update = new System.Windows.Forms.Button();
            this.bt_Delete = new System.Windows.Forms.Button();
            this.bt_Insert = new System.Windows.Forms.Button();
            this.tb_soLuong = new System.Windows.Forms.TextBox();
            this.tb_maNCC = new System.Windows.Forms.TextBox();
            this.tb_donGia = new System.Windows.Forms.TextBox();
            this.tb_maLoaiSanPham = new System.Windows.Forms.TextBox();
            this.tb_tenSanPham = new System.Windows.Forms.TextBox();
            this.tb_maSanPham = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Search = new System.Windows.Forms.TextBox();
            this.tb_trangThai = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1000, 247);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin";
            // 
            // dgv
            // 
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(0, 26);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(988, 231);
            this.dgv.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_trangThai);
            this.groupBox2.Controls.Add(this.tb_Search);
            this.groupBox2.Controls.Add(this.tb_diaChi);
            this.groupBox2.Controls.Add(this.tb_tenLoaiSanPham);
            this.groupBox2.Controls.Add(this.tb_tenNCC);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.bt_Search);
            this.groupBox2.Controls.Add(this.bt_Update);
            this.groupBox2.Controls.Add(this.bt_Delete);
            this.groupBox2.Controls.Add(this.bt_Insert);
            this.groupBox2.Controls.Add(this.tb_soLuong);
            this.groupBox2.Controls.Add(this.tb_maNCC);
            this.groupBox2.Controls.Add(this.tb_donGia);
            this.groupBox2.Controls.Add(this.tb_maLoaiSanPham);
            this.groupBox2.Controls.Add(this.tb_tenSanPham);
            this.groupBox2.Controls.Add(this.tb_maSanPham);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 282);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(994, 311);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Chi Tiết";
            // 
            // tb_diaChi
            // 
            this.tb_diaChi.Location = new System.Drawing.Point(518, 206);
            this.tb_diaChi.Name = "tb_diaChi";
            this.tb_diaChi.Size = new System.Drawing.Size(183, 27);
            this.tb_diaChi.TabIndex = 22;
            // 
            // tb_tenLoaiSanPham
            // 
            this.tb_tenLoaiSanPham.Location = new System.Drawing.Point(169, 260);
            this.tb_tenLoaiSanPham.Name = "tb_tenLoaiSanPham";
            this.tb_tenLoaiSanPham.Size = new System.Drawing.Size(176, 27);
            this.tb_tenLoaiSanPham.TabIndex = 21;
            // 
            // tb_tenNCC
            // 
            this.tb_tenNCC.Location = new System.Drawing.Point(169, 194);
            this.tb_tenNCC.Name = "tb_tenNCC";
            this.tb_tenNCC.Size = new System.Drawing.Size(176, 27);
            this.tb_tenNCC.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(398, 260);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "trangThai";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(398, 209);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "diaChi";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 265);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "tenLoaiSanPham";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "tenNCC";
            // 
            // bt_Search
            // 
            this.bt_Search.Location = new System.Drawing.Point(872, 147);
            this.bt_Search.Name = "bt_Search";
            this.bt_Search.Size = new System.Drawing.Size(101, 32);
            this.bt_Search.TabIndex = 15;
            this.bt_Search.Text = "Search";
            this.bt_Search.UseVisualStyleBackColor = true;
            this.bt_Search.Click += new System.EventHandler(this.bt_Search_Click);
            // 
            // bt_Update
            // 
            this.bt_Update.Location = new System.Drawing.Point(737, 240);
            this.bt_Update.Name = "bt_Update";
            this.bt_Update.Size = new System.Drawing.Size(101, 31);
            this.bt_Update.TabIndex = 14;
            this.bt_Update.Text = "Update";
            this.bt_Update.UseVisualStyleBackColor = true;
            this.bt_Update.Click += new System.EventHandler(this.bt_Update_Click);
            // 
            // bt_Delete
            // 
            this.bt_Delete.Location = new System.Drawing.Point(872, 240);
            this.bt_Delete.Name = "bt_Delete";
            this.bt_Delete.Size = new System.Drawing.Size(101, 31);
            this.bt_Delete.TabIndex = 13;
            this.bt_Delete.Text = "Delete";
            this.bt_Delete.UseVisualStyleBackColor = true;
            this.bt_Delete.Click += new System.EventHandler(this.bt_Delete_Click);
            // 
            // bt_Insert
            // 
            this.bt_Insert.Location = new System.Drawing.Point(737, 148);
            this.bt_Insert.Name = "bt_Insert";
            this.bt_Insert.Size = new System.Drawing.Size(101, 31);
            this.bt_Insert.TabIndex = 12;
            this.bt_Insert.Text = "Insert";
            this.bt_Insert.UseVisualStyleBackColor = true;
            this.bt_Insert.Click += new System.EventHandler(this.bt_Insert_Click);
            // 
            // tb_soLuong
            // 
            this.tb_soLuong.Location = new System.Drawing.Point(518, 140);
            this.tb_soLuong.Name = "tb_soLuong";
            this.tb_soLuong.Size = new System.Drawing.Size(183, 27);
            this.tb_soLuong.TabIndex = 11;
            // 
            // tb_maNCC
            // 
            this.tb_maNCC.Location = new System.Drawing.Point(518, 76);
            this.tb_maNCC.Name = "tb_maNCC";
            this.tb_maNCC.Size = new System.Drawing.Size(183, 27);
            this.tb_maNCC.TabIndex = 10;
            // 
            // tb_donGia
            // 
            this.tb_donGia.Location = new System.Drawing.Point(518, 36);
            this.tb_donGia.Name = "tb_donGia";
            this.tb_donGia.Size = new System.Drawing.Size(183, 27);
            this.tb_donGia.TabIndex = 9;
            // 
            // tb_maLoaiSanPham
            // 
            this.tb_maLoaiSanPham.Location = new System.Drawing.Point(169, 137);
            this.tb_maLoaiSanPham.Name = "tb_maLoaiSanPham";
            this.tb_maLoaiSanPham.Size = new System.Drawing.Size(176, 27);
            this.tb_maLoaiSanPham.TabIndex = 8;
            // 
            // tb_tenSanPham
            // 
            this.tb_tenSanPham.Location = new System.Drawing.Point(169, 80);
            this.tb_tenSanPham.Name = "tb_tenSanPham";
            this.tb_tenSanPham.Size = new System.Drawing.Size(176, 27);
            this.tb_tenSanPham.TabIndex = 7;
            // 
            // tb_maSanPham
            // 
            this.tb_maSanPham.Location = new System.Drawing.Point(169, 30);
            this.tb_maSanPham.Name = "tb_maSanPham";
            this.tb_maSanPham.Size = new System.Drawing.Size(176, 27);
            this.tb_maSanPham.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(398, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "soLuong";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(398, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "maNCC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(398, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "donGia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "maLoaiSanPham";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "tenSanPham";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "maSanPham";
            // 
            // tb_Search
            // 
            this.tb_Search.Location = new System.Drawing.Point(737, 58);
            this.tb_Search.Multiline = true;
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.Size = new System.Drawing.Size(236, 45);
            this.tb_Search.TabIndex = 24;
            // 
            // tb_trangThai
            // 
            this.tb_trangThai.FormattingEnabled = true;
            this.tb_trangThai.Items.AddRange(new object[] {
            "Đang hợp tác",
            "Không hợp tác"});
            this.tb_trangThai.Location = new System.Drawing.Point(518, 257);
            this.tb_trangThai.Name = "tb_trangThai";
            this.tb_trangThai.Size = new System.Drawing.Size(183, 28);
            this.tb_trangThai.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 605);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_soLuong;
        private System.Windows.Forms.TextBox tb_maNCC;
        private System.Windows.Forms.TextBox tb_donGia;
        private System.Windows.Forms.TextBox tb_maLoaiSanPham;
        private System.Windows.Forms.TextBox tb_tenSanPham;
        private System.Windows.Forms.TextBox tb_maSanPham;
        private System.Windows.Forms.Button bt_Update;
        private System.Windows.Forms.Button bt_Delete;
        private System.Windows.Forms.Button bt_Insert;
        private System.Windows.Forms.Button bt_Search;
        private System.Windows.Forms.TextBox tb_diaChi;
        private System.Windows.Forms.TextBox tb_tenLoaiSanPham;
        private System.Windows.Forms.TextBox tb_tenNCC;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_Search;
        private System.Windows.Forms.ComboBox tb_trangThai;
    }
}

