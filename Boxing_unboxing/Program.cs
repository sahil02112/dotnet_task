using System.Net.WebSockets;

namespace Boxing_unboxing
{
   // internal class Program
  //  {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Hello, World!");
//        }

//        class BoxingUnBoxing
////    {
////        //Static Memory - Stack
////        //Dynamic Memory - Heap        
////        public string Name { get; set; }

//        //        static void Main(string[] args)
//        //        {
//        //            BoxingUnBoxing obj = new BoxingUnBoxing();
//        //            obj.Name = "ABC";

//        //            int x = 10;

//        //            object y = x; //Boxing - Converting value type to ref type

//        //            int z = (int)y; //Unboxing - Converting value ref type to value type
//        //        }


//        //    }
//    }

    class BoxingUnBoxing
    {
        //Static Memory - Stack
        //Dynamic Memory - Heap        
        public string Name { get; set; }

            static void Main(string[] args)
            {
            //   BoxingUnBoxing obj = new BoxingUnBoxing();
            //    obj.Name = "ABC";

                int x = 10;

                object y = x; //Boxing - Converting value type to ref type

                int z = (int)y; //Unboxing - Converting value ref type to value type

            
            Console.WriteLine("value of x :" + x);
            Console.WriteLine("value of y :"+ y);
            Console.WriteLine("value of z :"+ z);

                
            }


        }
}
