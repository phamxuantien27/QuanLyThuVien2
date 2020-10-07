namespace QuanLyThuVien
{
    partial class US_PhieuMuoc
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.txtMaDocGia = new System.Windows.Forms.TextBox();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.dateMuon = new System.Windows.Forms.DateTimePicker();
            this.dateTra = new System.Windows.Forms.DateTimePicker();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rNgayMuon = new System.Windows.Forms.RadioButton();
            this.rMaPhieu = new System.Windows.Forms.RadioButton();
            this.rMaDocGia = new System.Windows.Forms.RadioButton();
            this.labelThongbao1 = new System.Windows.Forms.Label();
            this.lbThongbao2 = new System.Windows.Forms.Label();
            this.lbThongbao3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã phiếu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã độc giả";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã sách";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày mượn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày phải trả";
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(147, 28);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(230, 22);
            this.txtMa.TabIndex = 5;
            // 
            // txtMaDocGia
            // 
            this.txtMaDocGia.Location = new System.Drawing.Point(147, 63);
            this.txtMaDocGia.Name = "txtMaDocGia";
            this.txtMaDocGia.Size = new System.Drawing.Size(230, 22);
            this.txtMaDocGia.TabIndex = 6;
            // 
            // txtMaSach
            // 
            this.txtMaSach.Location = new System.Drawing.Point(147, 96);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(230, 22);
            this.txtMaSach.TabIndex = 7;
            // 
            // dateMuon
            // 
            this.dateMuon.CustomFormat = "yyyy//MM//dd";
            this.dateMuon.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateMuon.Location = new System.Drawing.Point(147, 138);
            this.dateMuon.Name = "dateMuon";
            this.dateMuon.Size = new System.Drawing.Size(230, 22);
            this.dateMuon.TabIndex = 8;
            // 
            // dateTra
            // 
            this.dateTra.CustomFormat = "yyyy/MM/dd";
            this.dateTra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTra.Location = new System.Drawing.Point(147, 182);
            this.dateTra.Name = "dateTra";
            this.dateTra.Size = new System.Drawing.Size(230, 22);
            this.dateTra.TabIndex = 9;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(20, 239);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 38);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(134, 239);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 38);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(248, 239);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 38);
            this.btnSua.TabIndex = 12;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(361, 239);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 38);
            this.btnHuy.TabIndex = 13;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 295);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1009, 211);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(508, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Tìm kiếm";
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(588, 28);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(230, 22);
            this.txtTim.TabIndex = 16;
            this.txtTim.TextChanged += new System.EventHandler(this.txtTim_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rNgayMuon);
            this.groupBox1.Controls.Add(this.rMaPhieu);
            this.groupBox1.Controls.Add(this.rMaDocGia);
            this.groupBox1.Location = new System.Drawing.Point(588, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 135);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm theo:";
            // 
            // rNgayMuon
            // 
            this.rNgayMuon.AutoSize = true;
            this.rNgayMuon.Location = new System.Drawing.Point(23, 86);
            this.rNgayMuon.Name = "rNgayMuon";
            this.rNgayMuon.Size = new System.Drawing.Size(101, 21);
            this.rNgayMuon.TabIndex = 19;
            this.rNgayMuon.TabStop = true;
            this.rNgayMuon.Text = "Ngày mượn";
            this.rNgayMuon.UseVisualStyleBackColor = true;
            // 
            // rMaPhieu
            // 
            this.rMaPhieu.AutoSize = true;
            this.rMaPhieu.Location = new System.Drawing.Point(23, 59);
            this.rMaPhieu.Name = "rMaPhieu";
            this.rMaPhieu.Size = new System.Drawing.Size(82, 21);
            this.rMaPhieu.TabIndex = 18;
            this.rMaPhieu.TabStop = true;
            this.rMaPhieu.Text = "Mã sách";
            this.rMaPhieu.UseVisualStyleBackColor = true;
            // 
            // rMaDocGia
            // 
            this.rMaDocGia.AutoSize = true;
            this.rMaDocGia.Location = new System.Drawing.Point(23, 32);
            this.rMaDocGia.Name = "rMaDocGia";
            this.rMaDocGia.Size = new System.Drawing.Size(98, 21);
            this.rMaDocGia.TabIndex = 0;
            this.rMaDocGia.TabStop = true;
            this.rMaDocGia.Text = "Mã độc giả";
            this.rMaDocGia.UseVisualStyleBackColor = true;
            // 
            // labelThongbao1
            // 
            this.labelThongbao1.AutoSize = true;
            this.labelThongbao1.ForeColor = System.Drawing.Color.Red;
            this.labelThongbao1.Location = new System.Drawing.Point(400, 33);
            this.labelThongbao1.Name = "labelThongbao1";
            this.labelThongbao1.Size = new System.Drawing.Size(100, 17);
            this.labelThongbao1.TabIndex = 18;
            this.labelThongbao1.Text = "Chưa nhập mã";
            // 
            // lbThongbao2
            // 
            this.lbThongbao2.AutoSize = true;
            this.lbThongbao2.ForeColor = System.Drawing.Color.Red;
            this.lbThongbao2.Location = new System.Drawing.Point(400, 66);
            this.lbThongbao2.Name = "lbThongbao2";
            this.lbThongbao2.Size = new System.Drawing.Size(165, 17);
            this.lbThongbao2.TabIndex = 19;
            this.lbThongbao2.Text = "Không tồn tại mã độc giả";
            // 
            // lbThongbao3
            // 
            this.lbThongbao3.AutoSize = true;
            this.lbThongbao3.ForeColor = System.Drawing.Color.Red;
            this.lbThongbao3.Location = new System.Drawing.Point(400, 96);
            this.lbThongbao3.Name = "lbThongbao3";
            this.lbThongbao3.Size = new System.Drawing.Size(84, 17);
            this.lbThongbao3.TabIndex = 20;
            this.lbThongbao3.Text = "Sách đã hết";
            // 
            // US_PhieuMuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbThongbao3);
            this.Controls.Add(this.lbThongbao2);
            this.Controls.Add(this.labelThongbao1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dateTra);
            this.Controls.Add(this.dateMuon);
            this.Controls.Add(this.txtMaSach);
            this.Controls.Add(this.txtMaDocGia);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "US_PhieuMuoc";
            this.Size = new System.Drawing.Size(1031, 534);
            this.Load += new System.EventHandler(this.US_PhieuMuon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.TextBox txtMaDocGia;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.DateTimePicker dateMuon;
        private System.Windows.Forms.DateTimePicker dateTra;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rNgayMuon;
        private System.Windows.Forms.RadioButton rMaPhieu;
        private System.Windows.Forms.RadioButton rMaDocGia;
        private System.Windows.Forms.Label labelThongbao1;
        private System.Windows.Forms.Label lbThongbao2;
        private System.Windows.Forms.Label lbThongbao3;
    }
}
