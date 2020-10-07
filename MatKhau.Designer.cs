namespace QuanLyThuVien
{
    partial class MatKhau
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
            this.btnThay = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMk2 = new System.Windows.Forms.TextBox();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThay
            // 
            this.btnThay.Location = new System.Drawing.Point(178, 395);
            this.btnThay.Name = "btnThay";
            this.btnThay.Size = new System.Drawing.Size(104, 57);
            this.btnThay.TabIndex = 4;
            this.btnThay.Text = "Thay Đổi";
            this.btnThay.UseVisualStyleBackColor = true;
            this.btnThay.Click += new System.EventHandler(this.btnThay_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtMk2);
            this.panel1.Controls.Add(this.txtMK);
            this.panel1.Controls.Add(this.txtTaiKhoan);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(38, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(402, 285);
            this.panel1.TabIndex = 3;
            // 
            // txtMk2
            // 
            this.txtMk2.Location = new System.Drawing.Point(140, 184);
            this.txtMk2.Name = "txtMk2";
            this.txtMk2.Size = new System.Drawing.Size(223, 22);
            this.txtMk2.TabIndex = 5;
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(140, 113);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(223, 22);
            this.txtMK.TabIndex = 4;
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(140, 46);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(223, 22);
            this.txtTaiKhoan.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhập lại MK";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên tài khoản";
            // 
            // MatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnThay);
            this.Controls.Add(this.panel1);
            this.Name = "MatKhau";
            this.Size = new System.Drawing.Size(511, 473);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnThay;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtMk2;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
