using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GymFitnessOlympic.View.Utils
{
    public static class DialogUtils
    {
        public static void ShowMessage(string message, string title = "Gym&Fitness thông báo")
        {
            System.Windows.Forms.MessageBox.Show(message, title, System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
        }

        public static void ShowError(string message, string title = "Gym&Fitness thông báo")
        {
            System.Windows.Forms.MessageBox.Show(message, title, System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
        }

        public static void ShowErrorWithTitle(string title, string stringFormat, params object[] args)
        {
            var msg = string.Format(stringFormat, args);
            if (string.IsNullOrEmpty(title))
                title = "Gym&Fitness thông báo";
            ShowError(msg, title);
        }

        public static void ShowErrorWithDefaultTitle(string stringFormat, params object[] args)
        {
            ShowErrorWithTitle("", stringFormat, args);
        }

        public static bool Confirmed(string stringFormat, params object[] args)
        {
            return MessageBox.Show(string.Format(stringFormat, args), "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

        public static bool ConfirmedWithTitle(string title, string stringFormat, params object[] args)
        {
            return MessageBox.Show(string.Format(stringFormat, args), title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

        public static DialogResult ShowOKCancel(string message, string title = "Gym&Fitness thông báo")
        {
            return System.Windows.Forms.MessageBox.Show(message, title, System.Windows.Forms.MessageBoxButtons.OKCancel, System.Windows.Forms.MessageBoxIcon.Error);
        }

        public static System.Windows.Forms.DialogResult DimAndShowDialog(this System.Windows.Forms.Form parentForm, System.Windows.Forms.Form dlg)
        {
            System.Windows.Forms.DialogResult result = System.Windows.Forms.DialogResult.None;
            var dimForm = new System.Windows.Forms.Form()
            {
                Text = "",
                ControlBox = false,
                FormBorderStyle = System.Windows.Forms.FormBorderStyle.None,
                Size = parentForm.Size,
                Location = parentForm.Location,
                BackColor = System.Drawing.Color.Black,
                ShowInTaskbar = false,
                Opacity = .5
            };
            dlg.FormClosing += (oSender, oE) =>
            {
                dimForm.Close();
                dimForm = null;
            };
            dimForm.Shown += (oSender, oE) =>
            {
                dimForm.Location = parentForm.Location;
                result = dlg.ShowDialog();
                parentForm.Focus();
            };
            dimForm.ShowDialog();
            return result;
        }

        private static System.Drawing.Point GetLastPositionFor(System.Windows.Forms.Form form)
        {
            return new System.Drawing.Point(0, 0);
        }

        public static void ShowAtLastPosition(this System.Windows.Forms.Form form)
        {
            var lastPos = GetLastPositionFor(form);
            form.Location = lastPos;
        }

        public static DialogResult ShowDialogAtLastPosition(this System.Windows.Forms.Form form)
        {
            var lastPos = GetLastPositionFor(form);
            return form.ShowDialog();
        }
    }
}
