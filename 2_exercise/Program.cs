using System;

namespace _2_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Converter solution\n");

            Converter ezConverter = new Converter(28.5, 35.3, 0.332);

            ezConverter.Conver();

            Console.ReadKey();
        }
    }
}
