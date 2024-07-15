using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_3.binding
{
    public class PartTimeEmployee :employee
    {
        public int CountOfHours { get; set;}

        public decimal HourRate { get; set; }

        public new void GetEmployeeType() {
            Console.WriteLine("I am Part time employee ");
        }
        public override void getEmployeeData()
        {
            Console.WriteLine($"FullTimeEmployee: Id = {Id} , Name = {Name} , Age = {Age} ,  count of Hour: {CountOfHours} , hour rate:  {HourRate}");
        }

    }
}
