﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L2D_WinformApp
{
    public partial class frmStaffInfo : Form
    {
        public frmStaffInfo()
        {
            InitializeComponent();
            RaiseEvent();
        }

        private void RaiseEvent()
        {
            btnClose.Click += btnClose_Click;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
