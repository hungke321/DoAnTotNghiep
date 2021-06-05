using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKhachSan
{
    public partial class frmQLLoaiPhong : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmQLLoaiPhong()
        {
            InitializeComponent();
        }
        ketnoiCSDL nv = new ketnoiCSDL();
        int flag;
        DataSet ds;
        void hienthidanhsach()
        {
            string sql = "select * from LoaiPhong";
            ds = nv.laydulieu(sql);
            dgvLoaiPhong.DataSource = ds.Tables[0];
        }
        private void btnHome_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
           
        }

        private void frmQLLoaiPhong_Load(object sender, EventArgs e)
        {
            hienthidanhsach();
        }
        void hienthitextbox(int vt)
        {           
            txtLoaiPhong.Text = ds.Tables[0].Rows[vt]["tenloaiphong"].ToString();
            txtSoGiuongDoi.Text = ds.Tables[0].Rows[vt]["sogiuongdoi"].ToString();
            txtSoGiuongDon.Text = ds.Tables[0].Rows[vt]["sogiuongdoi"].ToString();
            txtSoKhach.Text = ds.Tables[0].Rows[vt]["sokhach"].ToString();
            cbHieuLuc.Text = ds.Tables[0].Rows[vt]["hieuluc"].ToString();
        }

        private void dgvLoaiPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int vt = dgvLoaiPhong.CurrentCell.RowIndex;
            hienthitextbox(vt);
        }
    }
}