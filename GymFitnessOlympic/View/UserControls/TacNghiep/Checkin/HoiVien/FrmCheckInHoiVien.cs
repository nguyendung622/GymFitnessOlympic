using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using GymFitnessOlympic.Controller;
using GymFitnessOlympic.Models;
using GymFitnessOlympic.Models.Util;
using GymFitnessOlympic.View.Dialog;

namespace GymFitnessOlympic.View.MainForms
{
    public partial class FrmCheckinHoiVien : UserControl
    {
        HoiVien hv;
        bool isGYM;

        public FrmCheckinHoiVien(bool isGym = true)
        {
            InitializeComponent();
            this.isGYM = isGym;
            loadDefault();
            
        }

        private void btnCheckin_Click(object sender, EventArgs e)
        {

            wipeCard();
        }

        void wipeCard()
        {
            bool validCard = false;

            loadDefault();
            var st = txtMa.Text;
            hv = HoiVienController.CheckIn(txtMa.Text, isGYM);
            if (hv != null)
            {
                #region GYM
                if (isGYM)
                {
                    if (hv.NgayHetHanGYM > DateTime.Now)
                    {
                        validCard = true;
                        var hs = new HistoryHoiVien()
                        {
                            HoiVien = hv,
                            IsSauna = !isGYM,
                            ThoiGian = DateTime.Now
                        };
                        HistoryHoiVienController.Add(hs);
                        MessageBox.Show("Checkin thành công");
                    }
                    loadData();
                    if (validCard)
                    {
                        lblKetQua.ForeColor = Color.Green;
                        lblKetQua.Text = "Thẻ hợp lệ";
                        var delta = Convert.ToInt32(Math.Ceiling((hv.NgayHetHanGYM - DateTime.Now).TotalDays));
                        if (delta <= 7)
                        {
                            lblThongBao.Visible = true;
                            lblThongBao.ForeColor = Color.Purple;
                            lblThongBao.Text = "Còn " + delta + " ngày là hết hạn";
                        }
                    }
                    else
                    {
                        lblKetQua.ForeColor = Color.Red;
                        lblKetQua.Text = "Thẻ đã hết hạn";
                    }

                }
                #endregion GYM
                #region SAUNA
                else
                {
                    if (hv != null)
                    {

                        if (hv.NgayHetHanSauNa > DateTime.Now)
                        {
                            validCard = true;
                            var hs = new HistoryHoiVien() { 
                                HoiVien = hv,
                                IsSauna = !isGYM,
                                ThoiGian = DateTime.Now
                            };
                            HistoryHoiVienController.Add(hs);
                            MessageBox.Show("Checkin thành công");
                        }
                        loadData();
                        if (validCard)
                        {
                            lblKetQua.ForeColor = Color.Green;
                            lblKetQua.Text = "Thẻ hợp lệ";
                            var delta = Convert.ToInt32(Math.Ceiling((hv.NgayHetHanSauNa - DateTime.Now).TotalDays));
                            if (delta <= 7)
                            {
                                lblThongBao.Visible = true;
                                lblThongBao.ForeColor = Color.Purple;
                                lblThongBao.Text = "Còn " + delta + " ngày là hết hạn";
                            }

                        }
                        else
                        {
                            lblKetQua.ForeColor = Color.Red;
                            lblKetQua.Text = "Thẻ đã hết hạn";
                        }

                    }
                    else
                    {
                        lblKetQua.ForeColor = Color.Red;
                        lblKetQua.Text = "Không có tài khoản này";
                    }
                #endregion SAUNA
                    if (hv != null)
                    {
                        lblTen.Text = hv.TenHoiVien;
                    }
                    else lblTen.Text = "";
                }
            }
            else {
                lblKetQua.ForeColor = Color.Red;
                lblKetQua.Text = "Không có tài khoản này";
            }
        }

        private void loadDefault()
        {
            //lblKetQua.Visible = lblThongBao.Visible = false;
            lblThongBao.Text = lblKetQua.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtMa.Text = "63fe8695-4f55-4483-a803-960788f860fa";
            //MessageBox.Show(lblChucNang.Text);
        }

        void loadData()
        {

            lblPT_GiaHanCuoi.Text = DateTimeUtil.dateToString(hv.GiaHanCuoiGYM);
            lblPT_NgayHetHan.Text = DateTimeUtil.dateToString(hv.NgayHetHanGYM);
            var delta = Convert.ToInt32(Math.Ceiling((hv.NgayHetHanGYM - DateTime.Now).TotalDays));
            lblPT_SoNgayConLai.Text = (DateTime.Now.CompareTo(hv.NgayHetHanGYM) < 0) ?
                delta.ToString() : "Đã hết hạn";
        }

        private void btnGiaHan_Click(object sender, EventArgs e)
        {
            FrmGiaHan gh = new FrmGiaHan(hv, isGYM);
            if (gh.ShowDialog() == DialogResult.OK)
            {
                wipeCard();
            }
        }

        private void FrmCheckinHoiVien_Load(object sender, EventArgs e)
        {
            lblChucNang.Text = isGYM ? "Checkin GYM" : "Checkin Sauna";
        }
    }
}