﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace GymFitnessOlympic.Models
{
    public class GoiTap
    {

        public int MaGoiTap { get; set; }
        public PhongTap PhongTap { get; set; }
        public string TenGoiTap { get; set; }
        public int Gia { get; set; }
        public int SoThang { get; set; }
    }
}