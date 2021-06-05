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
using BUS;


namespace QLKhachSan
{
    public partial class frmQLLoaiPhong : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        LoaiPhongBUS lpb = new LoaiPhongBUS();
        public frmQLLoaiPhong()
        {           
            InitializeComponent();
        }
       
        private void btnHome_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
           
        }       
        private void frmQLLoaiPhong_Load(object sender, EventArgs e)
        {
            dgvLoaiPhong.DataSource = lpb.GetList();
        }
       
        private void dgvLoaiPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //int vt = dgvLoaiPhong.CurrentCell.RowIndex;
            //dgvLoaiPhong.DataSource = lpb.GetList();

        }

        private void ribbon_Click(object sender, EventArgs e)
        {
        }
    }
}