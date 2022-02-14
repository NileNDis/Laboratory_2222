using System;

namespace _2_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Converter solution\n");

            Converter ezConverter = new Converter(27, 30, 0.33);

            ezConverter.Choice();

            Console.ReadKey();
        }
    }
}
