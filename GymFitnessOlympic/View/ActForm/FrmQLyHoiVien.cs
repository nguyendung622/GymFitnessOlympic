using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using GymFitnessOlympic.View.UserControls;

namespace GymFitnessOlympic.View.MainForms
{
    public partial class FrmQLyHoiVien : DevExpress.XtraEditors.XtraForm
    {
        public FrmQLyHoiVien()
        {
            InitializeComponent();
            QLHoiVien qlHoiVien = new QLHoiVien();
            this.Size = qlHoiVien.Size;
            this.Controls.Add(qlHoiVien);
        }
    }
}