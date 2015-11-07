using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using GymFitnessOlympic.View;
using GymFitnessOlympic.View.MainForms;
using GymFitnessOlympic.View.Dialog;
using GymFitnessOlympic.View.ActForm.ThongKe;
using GymFitnessOlympic.View.ActForm;
using TanHongPhat;

namespace GymFitnessOlympic
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FrmCheckinNhanVien() );
          // 
            Application.Run(new MainForm());
            //Application.Run(new FrmCheckinNhanVien());
            //Application.Run(new FrmQLyNhanVien());
        }
    }
}
