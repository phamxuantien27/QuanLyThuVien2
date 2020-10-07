using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
using System.Data;
namespace BUS
{
    public class BUS_ThanhVien
    {
        DAO_ThanhVien tvDao = new DAO_ThanhVien();
        public bool DangNhap(string _tk, string _mk)
        {
            if (tvDao.login(_tk, _mk) == true)
                return true;
            return false;
        }
        public int DangKy(ThanhVien _tv)
        {
            if (string.IsNullOrEmpty(_tv.TenDangNhap) || string.IsNullOrEmpty(_tv.MatKhau))
                return -1;
            if (tvDao.signup(_tv) == true)
                return 1;
            return 0;
        }
        public void sua(DocGia _dg)
        {
            tvDao.Update(_dg);
        }
        public string Quyen(string s)
        {
            return tvDao.QuyenDN(s);
        }
        public DataTable GetThanhVien(string tdn)
        {
            return tvDao.getThanhVien(tdn);
        }
    }
}
