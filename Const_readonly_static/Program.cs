namespace 
onst_readonly_static
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("value before change : "+static_class.abc);
            update_value();
            Console.WriteLine("value after change : "+ static_class.abc);
        }

        public static class static_class
        {

            static public int abc = 1;

            static static_class()
            {
                abc = 2;
            }

            static void test()
            { 
            
            }
        }

        //private readonly static int abc;

        static void update_value()
        {
            static_class.abc = 23;
            Console.WriteLine("value of abc : "+static_class.abc );// value 0 
        }
    }

    //using System;
    //using System.Collections.Generic;
    //using System.IO;
    //using System.Linq;

    //namespace ConsoleApp3
    //{
    //    public static class StaticClass
    //    {
    //        //Static
    //        static int Calc = 1;

    //        static StaticClass()
    //        {
    //            Calc = 2;
    //        }

    //        static void Test()
    //        {

    //        }
    //    }

    //    class Constant_ReadOnly_Static
    //    {
    //        int abc = 4;

    //        static void Main(string[] args)
    //        {
    //            //Constant - can't modification value once declare and initialize
    //            const string DBString = "server=remote";
    //            const double Arith = 3.5;

    //            void DBConnection()
    //            {
    //                double calculate = Arith * 100;

    //                //Get COnnection

    //                string conn = DBString;
    //            }
    //        }

    //        private void ReadOnlyMethod()
    //        {
    //            Console.WriteLine(Calculation);
    //            Console.ReadLine();
    //        }

    //        //Read-Only - we can modify value in non-static constructor
    //        // we can assign value at the time of initilization or non static construtor

    //        private readonly double Calculation = 4.5;

    //        public Constant_ReadOnly_Static()
    //        {
    //            Calculation = 5.5;
    //        }

    //    }
    //}
}
