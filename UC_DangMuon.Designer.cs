namespace QuanLyThuVien
{
    partial class UC_DangMuon
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rHoTen = new System.Windows.Forms.RadioButton();
            this.rTenSach = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(256, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(269, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // rHoTen
            // 
            this.rHoTen.AutoSize = true;
            this.rHoTen.Location = new System.Drawing.Point(256, 99);
            this.rHoTen.Name = "rHoTen";
            this.rHoTen.Size = new System.Drawing.Size(71, 21);
            this.rHoTen.TabIndex = 1;
            this.rHoTen.TabStop = true;
            this.rHoTen.Text = "Họ tên";
            this.rHoTen.UseVisualStyleBackColor = true;
            // 
            // rTenSach
            // 
            this.rTenSach.AutoSize = true;
            this.rTenSach.Location = new System.Drawing.Point(415, 99);
            this.rTenSach.Name = "rTenSach";
            this.rTenSach.Size = new System.Drawing.Size(88, 21);
            this.rTenSach.TabIndex = 2;
            this.rTenSach.TabStop = true;
            this.rTenSach.Text = "Tên sách";
            this.rTenSach.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 151);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(886, 328);
            this.dataGridView1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tìm kiếm";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // UC_DangMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.rTenSach);
            this.Controls.Add(this.rHoTen);
            this.Controls.Add(this.textBox1);
            this.Name = "UC_DangMuon";
            this.Size = new System.Drawing.Size(925, 511);
            this.Load += new System.EventHandler(this.UC_DangMuon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton rHoTen;
        private System.Windows.Forms.RadioButton rTenSach;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
    }
}
