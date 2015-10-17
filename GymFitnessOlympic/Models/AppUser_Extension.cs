using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace GymFitnessOlympic.Models
{
    public partial class AppUser
    {
        public string _Description
        {
            get
            {
                return Role == 0 ? "Nhân viên" : "Admin";
            }
        }
        public string _Status
        {
            get
            {
                return IsActive ? "Đang hoạt động" : "Đã khóa";
            }
        }
    }
}
