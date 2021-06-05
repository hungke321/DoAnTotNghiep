using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DAO
{
    public class LoaiPhongDAO
    {
        dataKhachSan ds = new dataKhachSan();
        private LoaiPhongDTO hienthidanhsach(DataRow row)
        {
            LoaiPhongDTO lp = new LoaiPhongDTO();
            lp.ID = int.Parse(row["id"].ToString());
            lp.SOGIUONGDOI= row["sogiuongdoi"].ToString().Trim();
            lp.SOGIUONGDOI = row["sogiuongdoi"].ToString().Trim();
            lp.SOGIUONGDON = row["sogiuongdon"].ToString().Trim();
            lp.SOKHACH = row["sokhach"].ToString().Trim();
            lp.HIEULUC = row["hieuluc"].ToString().Trim();
            return lp;
        }
        public LoaiPhongDTO[] GetList()
        {
            LoaiPhongDTO[] list = null;
            DataTable table = null;
            int n = 0;

            table = ds.ExecuteQuery("select * from LoaiPhong");  //HIỂN THỊ TẤT CẢ LOẠI PHÒNG
            n = table.Rows.Count;

            if (n == 0)
            {
                return null;
            }

            list = new LoaiPhongDTO[n];
            for (int i = 0; i < n; i++)
            {
                LoaiPhongDTO s = hienthidanhsach(table.Rows[i]);
                list[i] = s;
            }

            return list;
        }

    }
}
