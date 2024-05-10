namespace tostring_converttostring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string abc = "sahil";
            string def = null;
            

            string a = abc.ToString();
            string c = Convert.ToString(abc);

         //   string d = def.ToString(); can't covert into string with .tostring with null value 
            string b=Convert.ToString(def);

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
           // Console.WriteLine(d);


        }
    }
}
