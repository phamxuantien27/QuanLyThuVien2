namespace QuanLyThuVien
{
    partial class ThongTin
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThayDoi = new System.Windows.Forms.Button();
            this.rNu = new System.Windows.Forms.RadioButton();
            this.rNam = new System.Windows.Forms.RadioButton();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTdn = new System.Windows.Forms.TextBox();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "  dd / MM / yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(301, 254);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(178, 22);
            this.dateTimePicker1.TabIndex = 69;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(404, 381);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 58);
            this.btnHuy.TabIndex = 68;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
        
            // 
            // btnThayDoi
            // 
            this.btnThayDoi.Location = new System.Drawing.Point(201, 381);
            this.btnThayDoi.Name = "btnThayDoi";
            this.btnThayDoi.Size = new System.Drawing.Size(75, 58);
            this.btnThayDoi.TabIndex = 67;
            this.btnThayDoi.Text = "Thay đổi";
            this.btnThayDoi.UseVisualStyleBackColor = true;
            this.btnThayDoi.Click += new System.EventHandler(this.btnThayDoi_Click);
            // 
            // rNu
            // 
            this.rNu.AutoSize = true;
            this.rNu.Location = new System.Drawing.Point(417, 199);
            this.rNu.Name = "rNu";
            this.rNu.Size = new System.Drawing.Size(47, 21);
            this.rNu.TabIndex = 66;
            this.rNu.TabStop = true;
            this.rNu.Text = "Nữ";
            this.rNu.UseVisualStyleBackColor = true;
            // 
            // rNam
            // 
            this.rNam.AutoSize = true;
            this.rNam.Location = new System.Drawing.Point(301, 199);
            this.rNam.Name = "rNam";
            this.rNam.Size = new System.Drawing.Size(58, 21);
            this.rNam.TabIndex = 65;
            this.rNam.TabStop = true;
            this.rNam.Text = "Nam";
            this.rNam.UseVisualStyleBackColor = true;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(301, 297);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(178, 22);
            this.txtDiaChi.TabIndex = 64;
            // 
            // txtTdn
            // 
            this.txtTdn.Location = new System.Drawing.Point(301, 145);
            this.txtTdn.Name = "txtTdn";
            this.txtTdn.Size = new System.Drawing.Size(178, 22);
            this.txtTdn.TabIndex = 63;
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(301, 96);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(178, 22);
            this.txtMa.TabIndex = 62;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(301, 49);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(178, 22);
            this.txtHoTen.TabIndex = 61;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(198, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 60;
            this.label6.Text = "Địa chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(198, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 59;
            this.label5.Text = "Năm sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(198, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 58;
            this.label4.Text = "Giới tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(198, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 57;
            this.label3.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 56;
            this.label2.Text = "Mã thành viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 55;
            this.label1.Text = "Họ tên";
            // 
            // ThongTin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnThayDoi);
            this.Controls.Add(this.rNu);
            this.Controls.Add(this.rNam);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtTdn);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ThongTin";
            this.Size = new System.Drawing.Size(618, 464);
            this.Load += new System.EventHandler(this.ThongTin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThayDoi;
        private System.Windows.Forms.RadioButton rNu;
        private System.Windows.Forms.RadioButton rNam;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTdn;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
