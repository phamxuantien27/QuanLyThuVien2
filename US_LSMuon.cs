using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace QuanLyThuVien
{
   
    public partial class US_LSMuon : UserControl
    {
        BUS_LichSu s = new BUS_LichSu();
        private string tdn;
        public US_LSMuon(string tdn2)
        {
            InitializeComponent();
            tdn = tdn2;
        }

        public string Tdn { get => tdn; set => tdn = value; }

        private void US_LSMuon_Load(object sender, EventArgs e)
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
