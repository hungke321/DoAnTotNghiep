using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiPhongDTO
    {     
        public int ID { get; set; }
      
        public string TENLOAIPHONG { get; set; }
       
        public string SOGIUONGDOI { get; set; }
       
        public string SOGIUONGDON { get; set; }
        
        public string SOKHACH { get; set; }
      
        public string HIEULUC { get; set; }   
     
        public LoaiPhongDTO()
        {
        }
    }
}
