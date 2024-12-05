using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_3.polymorphism
{
    internal class typeC:typeB
    {
        public int C { get; set; }
        public typeC(int a , int b , int c):base(a,b) {
            C = c;
        }
        public new void MyFun01() { 
            Console.WriteLine("I am Derived [Grand child]");
        }
        public override void MyFun02()
        {
            Console.WriteLine($"TypeC: A = {A} , B = {B} , C = {C}"); ;
        }
    }
}
