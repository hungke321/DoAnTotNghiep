﻿using DevExpress.XtraBars;
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
    public partial class frmQLPhong : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmQLPhong()
        {
            InitializeComponent();
        }

        private void btnHome_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
          
        }

        private void frmQLPhong_Load(object sender, EventArgs e)
        {

        }
    }
}