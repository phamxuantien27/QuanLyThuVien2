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
    public class BUS_DocGia
    {
        DAO_DocGia dgDao = new DAO_DocGia();
        public DataTable GetList()
        {
            return dgDao.loadDocGia();
        }
        public bool Them(DocGia dg)
        {
            return dgDao.Insert(dg);
        }
        public void Xoa(string mDG)
        {
            dgDao.Delete(mDG);
        }
        public bool Sua(DocGia dg)
        {
            if (string.IsNullOrEmpty(dg.MaDocGia))
                return false;
            dgDao.Update(dg);
            return true;
        }
        public DataTable TimKiem(string _timkiem)
        {
            return dgDao.Search(_timkiem);
        }
    }
}
