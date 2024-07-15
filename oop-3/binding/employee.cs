using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_3.binding
{
    public class employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public employee(int id , string name, int age) 
        {
        Id = id;
            Name = name;
                Age = age;
        }   
        public employee() { }   
        public void getEmployeeType() {
            Console.WriteLine("I am Employee");
        }
        public virtual void getEmployeeData() {
            Console.WriteLine($"Employee : Id = {Id} , Name = {Name} , Age = {Age}");
        }


    }
}
        