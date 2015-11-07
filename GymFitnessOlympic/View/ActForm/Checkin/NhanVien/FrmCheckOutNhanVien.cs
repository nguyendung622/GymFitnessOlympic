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
    public partial class FrmCheckOutNhanVien :UserControl
    {
        bool validCard = false;
        NhanVien nv;

        public FrmCheckOutNhanVien()
        {
            InitializeComponent();
            loadDefault();
        }

        private void btnCheckin_Click(object sender, EventArgs e)
        {

            wipeCard();
        }

        void loadData() {
            lblTenNhanVien.Text = nv.TenNhanVien;
            lblPhongTap.Text = (nv.PhongTap.TenPhongTap);
        }

        void wipeCard(bool checkin = true) {
            loadDefault();
            nv = NhanVienController.GetByMaThe(txtMa.Text.Trim());
            if (nv != null)
            {
                if (checkin)
                {
                    if (!NhanVienController.IsCheckedIn(nv.MaThe))
                    {
                        var hh = new HistoryNhanVien()
                        {
                            IsCheckin = true,
                            NhanVien = nv,
                            ThoiGian = DateTime.Now
                        };
                        var r = HistotyNhanVienController.Add(hh);
                        if (r == CODE_RESULT_RETURN.ThanhCong)
                        {
                            loadData();
                            lblKetQua.Text = "Đã checkin";
                            lblKetQua.ForeColor = Color.Green;
                        }
                        else
                        {
                            lblKetQua.Text = "Có lỗi khi checkin";
                            lblKetQua.ForeColor = Color.Red;
                        }
                    }
                    else
                    {
                        lblKetQua.ForeColor = Color.Purple;
                        lblKetQua.Text = "Nhân viên này đã checkin, chưa checkout";
                        loadData();
                    }
                }
                else { 
                    //Nguoi dung checkout
                    if (!NhanVienController.IsCheckedOut(nv.MaThe))
                    {
                        var hh = new HistoryNhanVien()
                        {
                            IsCheckin = false,
                            NhanVien = nv,
                            ThoiGian = DateTime.Now
                        };
                        var r = HistotyNhanVienController.Add(hh);
                        if (r == CODE_RESULT_RETURN.ThanhCong)
                        {
                            loadData();
                            lblKetQua.Visible = true;
                            lblKetQua.Text = "Đã checkout";
                            lblKetQua.ForeColor = Color.Green;
                        }
                        else
                        {
                            lblKetQua.Text = "Có lỗi khi checkout";
                            lblKetQua.ForeColor = Color.Red;
                        }
                    }
                    else
                    {
                        lblKetQua.ForeColor = Color.Purple;
                        lblKetQua.Text = "Nhân viên này đã checkout, chưa checkin";
                        loadData();
                    }
                }
            }
            else
            {
                lblKetQua.ForeColor = Color.Red;
                lblKetQua.Text = "Không có nhân viên này";
            }
            
        }

        private void loadDefault()
        {
            lblKetQua.Text = "";
            lblPhongTap.Text = lblTenNhanVien.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtMa.Text = "63fe8695-4f55-4483-a803-960788f860fa";
        }



      

        private void btnCheckin_Click_1(object sender, EventArgs e)
        {
            wipeCard();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            wipeCard(false);
        }
    }
}