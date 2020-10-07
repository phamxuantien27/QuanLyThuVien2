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
    public class BUS_DangTra
    {
        DangTra dtDao = new DangTra();
        public DataTable GetList()
        {
            return dtDao.loadSach();
        }
        public DataTable TimKiem(string _timkiem, string _loaitk)
        {
            return dtDao.Search(_timkiem, _loaitk);
        }
    }
}
