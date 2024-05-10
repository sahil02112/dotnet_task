using System.Data.SqlTypes;

namespace String_method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter string :");
            string abc = Convert.ToString(Console.ReadLine());
            char[] b = abc.ToCharArray();
            char[] c=new char[b.Length];
            int lng = c.Length-1;
            

            for (int i =0; i < abc.Length; i++)
            {
                c[lng-i] = b[i];
                Console.WriteLine(c[lng - i]);

            }
            string d = new string(c);
            Console.WriteLine(d);
            Console.ReadLine();
        }
    }
}
