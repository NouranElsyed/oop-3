namespace oop_3
{
    internal class Program
    {
        #region overloading
        public static int sum(int x, int y)
        { return x + y; }
      
        public static int sum(int x, int y, int z)
        { return x + y + z; }

        public static double sum(double x, double y)
        { return x + y  ; }

        public static double sum(int x, double y)
        { return x + y; }
        public static double sum(double x, int y)
        { return x + y; }
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
            #region
            #endregion
            #region
            #endregion
            #region
            #endregion
        }
    }
}
