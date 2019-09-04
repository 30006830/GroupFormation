﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeBackEnd
{
    public class Employee
    {
        public string Bank { get; set; }
        public int IRD { get; set; }
        public double Pay { get; set; }
        public double Hrs { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public string EmployeeDetails()
        {
            return $"Name: {Name}\n" +
                $"Age: {Age}\n" +
                $"Bank Account: {Bank}\n" +
                $"IRD: {IRD}\n" +
                $"Hourly Pay: {Pay}\n" +
                $"Hours Worked {Hrs}\n";
        }

    }
}
