using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class LoaiPhongBUS
    {
        private static LoaiPhongBUS instance;
        internal static LoaiPhongBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new LoaiPhongBUS();
                return instance;
            }
        }
        private LoaiPhongBUS() { }
        public void Xem(DataGridView Data) { }


    }
}
