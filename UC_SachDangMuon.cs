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
    public partial class UC_SachDangMuon : UserControl
    {
        BUS_SachDangMuon s = new BUS_SachDangMuon();
        private string tdn;
        public UC_SachDangMuon(string tdn2)
        {
            InitializeComponent();
            tdn = tdn2;
        }

        public string Tdn { get => tdn; set => tdn = value; }

        private void UC_SachDangMuon_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = s.GetList(tdn);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                dataGridView1.DataSource = s.GetList(tdn);

            }
            else
                dataGridView1.DataSource = s.TimKiem(textBox1.Text, tdn);
        }
    }
}
