using System.Numerics;

namespace If_else_condition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];
            int total=0,i;
            for (i = 0; i < 10; i++) 
            {
                a[i] = i;
                total = total + a[i];
            }

            Console.WriteLine("total of number "+total);

            total = 0;

          
                i = 0;
                while (i < 10)
                {
                    Console.WriteLine($"enter number {i+1} :");
                    a[i] = Convert.ToInt32(Console.ReadLine());
                    total = total + a[i];
                    i++;
                }
            
            float avg = total / 10;

            Console.WriteLine(avg);

            Console.WriteLine("\n how many number you want print for pattern");
            int number=Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= number; i++)
            {
                Console.Write($"\n 1");
                for (int j = 2; j <= i; j++)
                {
                    Console.Write($"{j}");
                }
            }


            Console.WriteLine("\n enter number to choose Day : ");
            Console.WriteLine("\n 1- monday \n2-tuesday \n3-wensday \n4- thrusday \n5-friday \n6-saturday \n7-sunday");
            int option=Convert.ToInt32(Console.ReadLine());

            String Day=Convert.ToString(Switch_case(option));

            Console.WriteLine($"you choose {Day}");

            String Switch_case(int option)
            {
                switch (option)
                {
                    case 1:
                        return "monday";
                        break;
                    case 2:
                        return "tuesday";
                        break;
                    case 3:
                        return "wnseday";
                        break;
                    case 4:
                        return "thrusday";
                        break;
                    case 5:
                        return "friday";
                        break;
                    case 6:
                        return "saturday";
                        break;
                    case 7:
                        return "sunday";
                        break;
                    default:
                        return "earror";
                        break;
                }

                Console.ReadLine();

            

            
        }

       
        }
    }
}