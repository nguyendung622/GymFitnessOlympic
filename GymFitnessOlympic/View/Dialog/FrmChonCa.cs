using GymFitnessOlympic.Controller;
using GymFitnessOlympic.Models.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GymFitnessOlympic.View.Dialog
{
    public partial class FrmChonCa : Form
    {
        public int maCa;

        public FrmChonCa()
        {
            InitializeComponent();
        }

        private void rdCaSang_CheckedChanged(object sender, EventArgs e)
        {
            btnOK.Enabled = true;
        }

        private void rdCaChieu_CheckedChanged(object sender, EventArgs e)
        {
            btnOK.Enabled = true;
        }

        private void rdCaToi_CheckedChanged(object sender, EventArgs e)
        {
            btnOK.Enabled = true;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            maCa = rdCaSang.Checked ? 1 : rdCaChieu.Checked ? 2 : 3;
            Login1.CaHienTai = CaLamViecController.Get(maCa);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
