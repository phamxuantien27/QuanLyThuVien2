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
    public class BUS_DangMuon
    {
         DangMuon dmDao = new DangMuon();
        public DataTable GetList()
        {
            return dmDao.loadSach();
        }
        public DataTable TimKiem(string _timkiem, string _loaitk)
        {
            return dmDao.Search(_timkiem, _loaitk);
        }
    }
}
