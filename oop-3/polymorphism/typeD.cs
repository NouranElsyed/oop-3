﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_3.polymorphism
{
    internal class typeD:typeC
    {
        public int D { get; set; }
        public typeD(int a, int b, int c,int d) : base(a, b,c)
        {
            D = d;
        }
        public new void MyFun01()
        {
            Console.WriteLine("I am Derived [Grand child]");
        }
        public new virtual void MyFun02()
        {
            Console.WriteLine($"TypeC: A = {A} , B = {B} , C = {C} , D = {D}"); 
        }
    }
}
