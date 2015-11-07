using DevExpress.XtraEditors.DXErrorProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GymFitnessOlympic.Models.Util.Validation
{
    class SoDienThoaiVL : ValidationRule
    {
        public override bool Validate(Control control, object value)
        {
            string st = value.ToString();
            long num;
            if (long.TryParse(st, out num))
            {
                return true;
            }
            else return false;
        }
    }
}
