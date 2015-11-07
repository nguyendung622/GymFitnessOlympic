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
    public partial class FrmQLyNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public FrmQLyNhanVien()
        {
            InitializeComponent();
            QLNhanVien q = new QLNhanVien();
            Controls.Add(q);
        }
    }
}