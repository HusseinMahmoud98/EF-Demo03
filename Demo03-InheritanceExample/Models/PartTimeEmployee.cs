﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo03_InheritanceExample.Models
{
    internal class PartTimeEmployee : Employee
    {
        public double HourRate { get; set; }
        public int NumberOfHours { get; set; }
    }
}
