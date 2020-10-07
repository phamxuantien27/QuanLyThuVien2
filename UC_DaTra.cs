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
    public partial class UC_DaTra : UserControl
    {
        BUS_DangTra s = new BUS_DangTra();
        public UC_DaTra()
        {
            InitializeComponent();
        }

        private void UC_DaTra_Load(object sender, EventArgs e)
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
