﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnQLKhachSan
{
    public partial class frmMenuQL : Form
    {
        public frmMenuQL()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMenuQL_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult response = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (response == DialogResult.No)
                e.Cancel = true;
        }
    }
}
