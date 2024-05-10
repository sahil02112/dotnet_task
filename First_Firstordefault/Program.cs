using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ConsoleApp3
{
    class First_FirstOrDefault
    {
        static void Main(string[] args)
        {
            //First - take first element from collaction but can't hanlde null/empty value
            //FirstOrDefault - take first element from collaction but can hanlde null/empty value


            List<string> s1 = new List<string>();
            List<int> i1 = new List<int>();

            s1.Add("sahil");
            i1.Add(2);

            String s1_first = s1.First();
            String s1_firstorDefault = s1.FirstOrDefault();

            int i1_first = i1.First();
            int i1_firstorDefault = i1.FirstOrDefault();

            Console.WriteLine("string with first :" + s1_first);
            Console.WriteLine("strig with first or default  :" + s1_firstorDefault);
            Console.WriteLine("intger with first :" + i1_first);
            Console.WriteLine("intger with first or default : " + i1_firstorDefault);


        }
    }
}
}