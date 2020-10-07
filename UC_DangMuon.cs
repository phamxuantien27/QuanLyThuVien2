using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace QuanLyThuVien
{
    public partial class UC_DangMuon : UserControl
    {
        BUS_DangMuon s = new BUS_DangMuon();
        public UC_DangMuon()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UC_DangMuon_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = s.GetList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                dataGridView1.DataSource = s.GetList();

            }
            else
            {
                if (rHoTen.Checked == true)
                    dataGridView1.DataSource = s.TimKiem(textBox1.Text, "HoTen");
                else if (rTenSach.Checked == true)
                    dataGridView1.DataSource = s.TimKiem(textBox1.Text, "TenSach");
            }
        }
    }
}
