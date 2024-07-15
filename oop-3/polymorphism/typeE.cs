using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_3.polymorphism
{
    internal class typeE : typeD
    {
        public int E { get; set; }
        public typeE(int a, int b, int c, int d , int e) : base(a, b, c,d)
        {
            D = d;
        }
        public new void MyFun01()
        {
            Console.WriteLine("I am Derived [Grand child]");
        }
        public override void MyFun02()
        {
            Console.WriteLine($"TypeC: A = {A} , B = {B} , C = {C} , D = {D} , E = {E}");
        }
    }

}
