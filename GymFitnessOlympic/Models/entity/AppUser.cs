using System;
using System.Collections.Generic;

namespace GymFitnessOlympic.Models
{
    public partial class AppUser
    {
        public AppUser()
        {

        }

        public string UserName { get; set; }
        public string FullName { get; set; }
        public string Password { get; set; }
        public int Role { get; set; }
        public bool IsActive { get; set; }
    }
}
