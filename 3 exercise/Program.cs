using System;

namespace _3_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Employee solution\n");

            Employee den = new Employee("Denis", " Danilenko");

            den.Rozrahunok();

            den.Write();

            Console.ReadKey();
        }
    }
}
