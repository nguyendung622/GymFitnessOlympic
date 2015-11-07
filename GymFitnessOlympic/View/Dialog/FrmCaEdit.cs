using GymFitnessOlympic.Controller;
using GymFitnessOlympic.Models;
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
    public partial class FrmCaEdit : Form
    {
        CaLamViec current;

        public FrmCaEdit(CaLamViec ca)
        {
            InitializeComponent();
            current = ca;
            spnGioBatDau.Text = ca.GioBatDau.Hours.ToString();
            spnPhutBatDau.Text = ca.GioBatDau.Minutes.ToString();
            spnGioKetThuc.Text = ca.GioKetThuc.Hours.ToString();
            spnPhutKetThuc.Text = ca.GioKetThuc.Minutes.ToString();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            current.GioBatDau = new TimeSpan(Convert.ToInt32(spnGioBatDau.Text), Convert.ToInt32(spnPhutBatDau.Text), 0);
            current.GioKetThuc = new TimeSpan(Convert.ToInt32(spnGioKetThuc.Text), Convert.ToInt32(spnPhutKetThuc.Text), 0);
            var t = CaLamViecController.Update(current);
            switch (t) { 
                case CODE_RESULT_RETURN.MaTrung:
                    MessageBox.Show("Lỗi: Có sự chồng lấp thời gian giữa các ca");
                    return;
                case CODE_RESULT_RETURN.ThanhCong:
                    DialogResult = DialogResult.OK;
                    MessageBox.Show("Cập nhật thành công");
                    return;
                default:
                    MessageBox.Show("Lỗi khi cập nhật");
                    return;  
            }
        }
    }
}
