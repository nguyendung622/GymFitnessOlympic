using DevExpress.XtraEditors;
using GymFitnessOlympic.Controller;
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
    public partial class FrmCauHinh : Form
    {
         string sNgayTruocSinhNhat = "NSN";
         string sNgayHetHan = "NHH";
         string sGioBatDau = "GBD";
         string sPhutBatDau = "PBD";
         string sGioKetPhuc = "GKT";
         string sPhutKetThuc = "PKT";


        public FrmCauHinh()
        {
          
            InitializeComponent();
            initValueDefault();
            spnBaoHetHan.Properties.MinValue = 0;
        }

        void initValueDefault() {
            spnBaoSinhNhat.Text = KeyValueController.Get(sNgayTruocSinhNhat);
            spnBaoHetHan.Text = KeyValueController.Get(sNgayHetHan);
            //
            //spnGioBatDau.Text = KeyValueController.Get(sGioBatDau);
            //spnPhutBatDau.Text = KeyValueController.Get(sPhutBatDau);
            ////
            //spnPhutKetThuc.Text = KeyValueController.Get(sPhutKetThuc);
            //spnGioKetThuc.Text = KeyValueController.Get(sGioKetPhuc);
        }
       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int gioBatDau, gioKetThuc, phutBatDau, phutKetThuc, ngayHetHan, ngaySinhNhat;
           

            //KeyValueController.Set(sGioBatDau, spnGioBatDau.Text);
            //KeyValueController.Set(sGioKetPhuc, spnGioKetThuc.Text);
            //KeyValueController.Set(sPhutBatDau, spnPhutBatDau.Text);
            //KeyValueController.Set(sPhutKetThuc, spnPhutKetThuc.Text);
            KeyValueController.Set(sNgayHetHan, spnBaoHetHan.Text);
            KeyValueController.Set(sNgayTruocSinhNhat, spnBaoSinhNhat.Text);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void spnGioBatDau_EditValueChanged(object sender, EventArgs e)
        {
            if (spnBaoHetHan.Value < 0)
                return;
        }

    

     

        private void spnBaoHetHan_EditValueChanged(object sender, EventArgs e)
        {
            if (spnBaoHetHan.Value < 0)
                return;
        }

        private void spnBaoSinhNhat_EditValueChanged(object sender, EventArgs e)
        {
            if (spnBaoSinhNhat.Value < 0)
                return;
        }

        private void btnGioLamViec_Click(object sender, EventArgs e)
        {
            FrmCaList f = new FrmCaList();
            f.ShowDialog();
        }
    }


    
}
