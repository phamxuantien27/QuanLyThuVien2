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
    public class BUS_Sach
    {
        DAO_Sach sachDao = new DAO_Sach();
        public DataTable GetList()
        {
            return sachDao.loadSach();
        }
        public void Xoa(string mS)
        {
            sachDao.Delete(mS);
        }
        public bool Sua(Sach s)
        {
            if (string.IsNullOrEmpty(s.MaSach))
                return false;
            sachDao.Update(s);
            return true;
        }
        public bool Them(Sach s)
        {
            return sachDao.Insert(s);
        }
        public DataTable TimKiem(string _timkiem, string _loaitk)
        {
            return sachDao.Search(_timkiem, _loaitk);
        }
    }
}
