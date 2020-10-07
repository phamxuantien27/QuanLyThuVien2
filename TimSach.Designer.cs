namespace QuanLyThuVien
{
    partial class TimSach
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rNXB = new System.Windows.Forms.RadioButton();
            this.rTheLoai = new System.Windows.Forms.RadioButton();
            this.rTinhtrang = new System.Windows.Forms.RadioButton();
            this.rTacGia = new System.Windows.Forms.RadioButton();
            this.rTenSach = new System.Windows.Forms.RadioButton();
            this.rMa = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTimSach = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 289);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1184, 230);
            this.dataGridView1.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rNXB);
            this.groupBox1.Controls.Add(this.rTheLoai);
            this.groupBox1.Controls.Add(this.rTinhtrang);
            this.groupBox1.Controls.Add(this.rTacGia);
            this.groupBox1.Controls.Add(this.rTenSach);
            this.groupBox1.Controls.Add(this.rMa);
            this.groupBox1.Location = new System.Drawing.Point(360, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 161);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm theo:";
            // 
            // rNXB
            // 
            this.rNXB.AutoSize = true;
            this.rNXB.Location = new System.Drawing.Point(188, 123);
            this.rNXB.Name = "rNXB";
            this.rNXB.Size = new System.Drawing.Size(113, 21);
            this.rNXB.TabIndex = 5;
            this.rNXB.TabStop = true;
            this.rNXB.Text = "Nhà xuất bản";
            this.rNXB.UseVisualStyleBackColor = true;
            // 
            // rTheLoai
            // 
            this.rTheLoai.AutoSize = true;
            this.rTheLoai.Location = new System.Drawing.Point(34, 123);
            this.rTheLoai.Name = "rTheLoai";
            this.rTheLoai.Size = new System.Drawing.Size(80, 21);
            this.rTheLoai.TabIndex = 4;
            this.rTheLoai.TabStop = true;
            this.rTheLoai.Text = "Thể loại";
            this.rTheLoai.UseVisualStyleBackColor = true;
            // 
            // rTinhtrang
            // 
            this.rTinhtrang.AutoSize = true;
            this.rTinhtrang.Location = new System.Drawing.Point(188, 80);
            this.rTinhtrang.Name = "rTinhtrang";
            this.rTinhtrang.Size = new System.Drawing.Size(94, 21);
            this.rTinhtrang.TabIndex = 3;
            this.rTinhtrang.TabStop = true;
            this.rTinhtrang.Text = "Tình trạng";
            this.rTinhtrang.UseVisualStyleBackColor = true;
            // 
            // rTacGia
            // 
            this.rTacGia.AutoSize = true;
            this.rTacGia.Location = new System.Drawing.Point(34, 80);
            this.rTacGia.Name = "rTacGia";
            this.rTacGia.Size = new System.Drawing.Size(76, 21);
            this.rTacGia.TabIndex = 2;
            this.rTacGia.TabStop = true;
            this.rTacGia.Text = "Tác giả";
            this.rTacGia.UseVisualStyleBackColor = true;
            // 
            // rTenSach
            // 
            this.rTenSach.AutoSize = true;
            this.rTenSach.Location = new System.Drawing.Point(188, 39);
            this.rTenSach.Name = "rTenSach";
            this.rTenSach.Size = new System.Drawing.Size(90, 21);
            this.rTenSach.TabIndex = 1;
            this.rTenSach.TabStop = true;
            this.rTenSach.Text = "Tên Sách";
            this.rTenSach.UseVisualStyleBackColor = true;
            // 
            // rMa
            // 
            this.rMa.AutoSize = true;
            this.rMa.Location = new System.Drawing.Point(34, 39);
            this.rMa.Name = "rMa";
            this.rMa.Size = new System.Drawing.Size(82, 21);
            this.rMa.TabIndex = 0;
            this.rMa.TabStop = true;
            this.rMa.Text = "Mã sách";
            this.rMa.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(357, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tìm sách";
            // 
            // txtTimSach
            // 
            this.txtTimSach.Location = new System.Drawing.Point(437, 65);
            this.txtTimSach.Name = "txtTimSach";
            this.txtTimSach.Size = new System.Drawing.Size(204, 22);
            this.txtTimSach.TabIndex = 4;
            this.txtTimSach.TextChanged += new System.EventHandler(this.txtTimSach_TextChanged);
            // 
            // TimSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTimSach);
            this.Name = "TimSach";
            this.Size = new System.Drawing.Size(1217, 536);
            this.Load += new System.EventHandler(this.TimSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rNXB;
        private System.Windows.Forms.RadioButton rTheLoai;
        private System.Windows.Forms.RadioButton rTinhtrang;
        private System.Windows.Forms.RadioButton rTacGia;
        private System.Windows.Forms.RadioButton rTenSach;
        private System.Windows.Forms.RadioButton rMa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTimSach;
    }
}
