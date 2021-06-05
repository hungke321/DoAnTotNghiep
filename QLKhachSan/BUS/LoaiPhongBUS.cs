using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace BUS
{
    public class LoaiPhongBUS
    {     
        LoaiPhongDAO lp = new LoaiPhongDAO();
        public LoaiPhongDTO[] GetList()
        {
            return lp.GetList();
        }

    }
}
