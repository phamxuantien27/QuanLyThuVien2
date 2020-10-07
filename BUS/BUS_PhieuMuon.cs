using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAO;
using DTO;
using System.Data;
namespace BUS
{
    public class BUS_PhieuMuon
    {
        DAO_PhieuMuon pmDao = new DAO_PhieuMuon();
        public DataTable GetList()
        {
            return pmDao.loadPhieuMuon();
        }
        public bool CheckExist(string _table, string _str)
        {
            return pmDao.CheckExist(_table, _str);

        }
        public void Xoa(string _mp)
        {
            pmDao.Delete(_mp);
        }
        public bool Sua(PhieuMuon _pm)
        {
            if (string.IsNullOrEmpty(_pm.MaPhieu))
                return false;
            pmDao.Update(_pm);
            return true;
        }
        public int Them(PhieuMuon _pm)
        {
            if (string.IsNullOrEmpty(_pm.MaPhieu))
                return 0;
            if (!pmDao.Insert(_pm))
                return -1;
            return 1;
        }
        public DataTable TimKiem(string _timkiem, string _loaitk)
        {
            return pmDao.Search(_timkiem, _loaitk);
        }
    }
}
