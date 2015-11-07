using DevExpress.XtraEditors;
using GymFitnessOlympic.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GymFitnessOlympic.Models.DataFiller
{
    class DataFiller
    {
        public static void fillPhongCombo( LookUpEdit cbb, List<PhongTap> l = null) {
            if (l == null)
            {
                 l = PhongTapController.GetList();
            }
            cbb.Properties.DataSource = l;
            cbb.Properties.ValueMember = "MaPhongTap";
            cbb.Properties.DisplayMember = "TenPhongTap";
            
        }

        public static void fillPhongCombo(ComboBoxEdit cbb, List<PhongTap> l = null)
        {
            if (l == null)
            {
                l = PhongTapController.GetList();
            }
            cbb.Properties.Items.Clear();
            foreach(var p in l){
                cbb.Properties.Items.Add(p);
            }
            if (cbb.Properties.Items.Count > 0) {
                cbb.SelectedIndex = 0;
            }
        }

        public static void fillGoiCombo(System.Windows.Forms.ComboBox cbb, int typeID, int phongID, List<GoiTap> gois = null ) {
            if(gois == null){
                gois = GoiTapController.GetList(typeID,phongID);
            }
            cbb.DataSource = gois;
            cbb.DisplayMember = "TenGoiTap";
            cbb.ValueMember = "SoThang";
        }

       
    }
}
