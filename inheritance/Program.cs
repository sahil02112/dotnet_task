using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;

namespace inheritance
{
    internal class Program
    {

        public class a
        {
            public int emp;

            public void person()
            {
                Console.WriteLine("for class a");
            }
        }

        public class b : a
        {
            public string name;

            public void person1()
            {
                Console.WriteLine("for class b");
            }
        }

        class c : b
        {
            public void person2()
            {
                Console.WriteLine("for class c");
            }
        }

        // hyrarichal 

        class h1
        {
            public void h_1()
            {
                Console.WriteLine("class h1");
            }
        }
        class h2 : h1
        {
            public void h_2()
            {
                Console.WriteLine("class h2");
            }

        }

        class h3 : h1
        {
            public void h_3()
            {
                Console.WriteLine("class h3");
            }
        }

        // interface 

        interface i_1
        {
            void display () { }
            void print() { }
        }

       
        interface i_2
        {
            void print() { }
            void display() { }
        }

        class inter_class: i_1,i_2
        {

            // implicite 
            public void display()
            {
                Console.WriteLine("inerface i1 and i2 implicite ");
            }

            void i_1.print()
            {
                Console.WriteLine("interface 1");
            }

            void i_2.print()
            {
                Console.WriteLine("interface 2");
            }
          
        }



        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            a obj1 = new a();
            obj1.person();

            b obj2 = new b();
            obj2.person();

            c obj3 = new c();

            obj3.person();
            obj3.person1();//multilevel inheritance 
            obj3.person2();


            // hyrarichal 

            h2 obj = new h2();
            h3 obj4 = new h3();

            obj.h_1();// PERANT CLASS CALLING 
            obj.h_2();// H_2 CLASS CALLING 

            obj4.h_1();// PERENT CLASSS CALLING 
            obj.h_2();  // H3 CLASS CALLING 




            // interface 

            inter_class int_1=new inter_class();
            int_1.display();

            i_1 int_2= new inter_class();  // object of interface 1
            i_2 int_3 = new inter_class(); // object of interface 2

            int_2.print();  // calling print method of interface 1 
            int_3.print();  // calling print method of interface 2

            Console.ReadLine(); 

        }
    }
}