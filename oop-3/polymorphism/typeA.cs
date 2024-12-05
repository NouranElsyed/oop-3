using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_3.polymorphism
{
    internal class typeA

    {
        public int A { get; set; }

        public typeA(int a) { A = a; }

        public void MyFun01() { Console.WriteLine("I am Base [parent]"); }

        public virtual void MyFun02() { Console.WriteLine($"TypeA : A = {A}"); }

    }
} 
 