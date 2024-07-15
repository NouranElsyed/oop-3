using oop_3.polymorphism;



namespace oop_3
{
    internal class Program
    {
        #region overloading
        //public static int sum(int x, int y)
        //{ return x + y; }
      
        //public static int sum(int x, int y, int z)
        //{ return x + y + z; }

        //public static double sum(double x, double y)
        //{ return x + y  ; }

        //public static double sum(int x, double y)
        //{ return x + y; }
        //public static double sum(double x, int y)
        //{ return x + y; }
        #endregion
        static void Main(string[] args)
        {

            #region polymorphism [overloading]
            //int Result = sum(1, 2);
            //Console.WriteLine($"Result = {Result}");//3
            //Result = sum(1, 2,3);
            //Console.WriteLine($"Result = {Result}");//6
            //double Result02 = sum(1.5 , 2.8);
            //Console.WriteLine($"Result02 = {Result02}");//4.3
            // Result02 = sum(2, 2.8);
            //Console.WriteLine($"Result02 = {Result02}");//4.8
            //Result02 = sum(3.8,5);
            //Console.WriteLine($"Result02 = {Result02}");//4.8
            //Console.WriteLine();
            #endregion
            #region [override]
            //typeA typeA = new typeA(1);
            //    typeA.A = 10;
            //typeB typeB = new typeB(1,2);
            //typeB.A = 10;
            //typeB.B = 20;
            //typeB.MyFun01();
            //typeB.MyFun02();




            #endregion
            #region Binding
            //typeA refbase;
            //refbase = new typeB(1,2);
            //refbase.A = 10;
            ////refbase.B = 10; invalid

            //refbase.MyFun01();// I am Base[parent]
            //refbase.MyFun02();// TypeB: A = 10 , B = 2



            #endregion
            #region Not Binding
            //typeB childref = new typeA();   invalid
            //typeB childref = (typeB) new typeA(1); // not binding /explicit casting / unsafe casting
           
            
            //typeA typeA = new typeA(1);
            //typeB  typeB = (typeB) typeA;

            //Console.WriteLine(typeB.A);
            //Console.WriteLine(typeB.B);


            typeA typeA = new typeB(1,2);
            typeB typeB = (typeB)typeA;

            Console.WriteLine(typeB.A);
            Console.WriteLine(typeB.B);

            #endregion
            #region
            #endregion
        }
    }
}
