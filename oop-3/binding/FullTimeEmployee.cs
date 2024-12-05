﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_3.binding
{
    internal class FullTimeEmployee : employee
    {
        public FullTimeEmployee(int id , string name , int age ,decimal salary) : base( id,name, age)
            { Salary = salary; }
        public decimal Salary { get; set; }
        public override void getEmployeeData()
        {
            Console.WriteLine($"Employee : Id = {Id} , Name = {Name} , Age = {Age}");
        }
    }
}
