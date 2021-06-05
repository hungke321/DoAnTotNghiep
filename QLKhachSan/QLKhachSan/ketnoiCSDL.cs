using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QLKhachSan
{
    class ketnoiCSDL
    {
        SqlConnection con = new SqlConnection();

        //liên kết data qua form
        void ketnoi()
        {
            con.ConnectionString = @"data source =DESKTOP-DDKM1BA\SQLEXPRESS; initial catalog=QLKhachSan; integrated security=true";
            if (con.State == ConnectionState.Closed)
                con.Open();
        }
        void dongketnoi()
        {
            con.Close();
        }
        public ketnoiCSDL()
        {
            ketnoi();
        }
        public DataSet laydulieu(string sql)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(ds);
            return ds;
        }
        //cập nhật dữ liệu

        public int Capnhat(string sql)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;

            return cmd.ExecuteNonQuery();
        }


    }
}
