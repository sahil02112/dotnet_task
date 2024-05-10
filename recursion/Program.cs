using System.Data;
using System.Text;

namespace recursion
{
    internal class Program
    {
        // int b = 1;
        public class student()
        {
           public string student_name;
            
        }
        static void Main(string[] args)
        {
            Console.Write("enter a number for factorial :");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            int b = 1;
            Fact(a,b);

            //Console.WriteLine($"First Arg: {args[0]}");
            ////            //Need to connect with DB
            //  string connectionString = args[0].ToString();

            student s1=new student();
            s1.student_name = "sahil";
            Console.WriteLine("name before change : "+s1.student_name);
            Updatename(s1);
            Console.WriteLine("name after change : " + s1.student_name);

            StringBuilder  sb1=new StringBuilder();
            sb1.Append("jani");
            Console.WriteLine(sb1);
            sb1.Replace("jani","sahil");
            Console.WriteLine(sb1);

              Console.ReadLine();
        }

        static void Updatename(student s1)
        {
            s1.student_name = "harsh";
        }
        static void Fact(int a, int b)
        {
            if (a == 1)
                Console.Write($"{a}");
            else
                Console.Write($"{a}*");

            b = b * a;
            a--;


            if (a > 0)
            {
                Fact(a, b);

            }
            else
                Console.WriteLine($"\ntotal of factorial is : {b}");
        }

    }
}
