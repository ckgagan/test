using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Demo
{
    public partial class Journal : Form
    {
        public Journal()
        {
            InitializeComponent();
            
        }

        public void disableAddVoucher()
        {
            addVoucherBtn.Text = "Disabled";
        }

        private void addVoucherBtn_Click(object sender, EventArgs e)
        {
            voucher newVoucher = new voucher(this);
            newVoucher.Show();
        }
    }
}