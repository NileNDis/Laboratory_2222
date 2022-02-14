using System;

namespace _3_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Employee solution\n");

            Employee denchik = new Employee("Denis", " Danilenko");

            denchik.Rozrahunok();

            denchik.Write();

            Console.ReadKey();
        }
    }
}
