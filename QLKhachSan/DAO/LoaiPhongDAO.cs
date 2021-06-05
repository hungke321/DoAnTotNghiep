using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class LoaiPhongDAO
    {
        private static LoaiPhongDAO instance;
        internal static LoaiPhongDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new LoaiPhongDAO();
                return instance;
            }
        }
        private LoaiPhongDAO() { }
        public List<LoaiPhongDTO> Xem()
        {
            List<LoaiPhongDTO> loaiPhongDTOs = new List<LoaiPhongDTO>();
            return loaiPhongDTOs;

        }
    }
}
