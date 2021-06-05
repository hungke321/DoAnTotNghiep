using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiPhongDTO
    {
        private int id;
        private string tenLoaiPhong;
        private string soGiuongDoi;
        private string soGiuongDon;
        private string soKhach;
        private string hieuLuc;

        //thực hiện get/set
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public string TENLOAIPHONG
        {
            get { return tenLoaiPhong; }
            set { tenLoaiPhong = value; }
        }
        public string SOGIUONGDOI
        {
            get { return soGiuongDoi; }
            set { soGiuongDoi = value; }
        }
        public string SOGIUONGDON
        {
            get { return soGiuongDon; }
            set { soGiuongDon = value; }
        }
        public string SOKHACH
        {
            get { return soKhach; }
            set { soKhach = value; }
        }
        public string HIEULUC
        {
            get { return hieuLuc; }
            set { hieuLuc = value; }
        }
        public LoaiPhongDTO(int id, string tenLoaiPhong, string soGiuongDoi, string soGiuongDon, string soKhach, string hieuLuc)
        {
            this.ID = id;
            this.TENLOAIPHONG = tenLoaiPhong;
            this.SOGIUONGDOI = soGiuongDoi;
            this.SOGIUONGDON = soGiuongDon;
            this.SOKHACH = soKhach;
            this.HIEULUC = hieuLuc;

        }
    }
}
