namespace oprator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int a,b;

            Console.WriteLine("enter value of a :");
            a=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter value of b:");
            b = Convert.ToInt32(Console.ReadLine());

            if (a == b)
            { Console.WriteLine("an & b has same value"); }
            else if (a>b)
            { Console.WriteLine("a is greater than b"); }
            else { Console.WriteLine("b is greate han a"); }

            Console.WriteLine($"value of a is {a}");

            a = a++;

            Console.WriteLine($"value of a is {a}");

            a += a;

            Console.WriteLine($"value of a is {a}");

            if (a == b && a > b)
            {
                Console.WriteLine("a is greater than or equle to b");  
            }

            if (a == b && a < b)
            {
                Console.WriteLine("a is less than or equle to b");
            }

            int number = 10;
            string result = (number % 2 == 0) ? "even" : "odd";
            Console.WriteLine($"The number is {result}.");

            Console.ReadLine();

        }
    }
}
