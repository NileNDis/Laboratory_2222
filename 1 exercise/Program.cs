using System;

namespace _1_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Address solution\n");
            Address someAddress = new Address();

            someAddress.Index = 500;
            someAddress.Country = "Ukraine";
            someAddress.City = "Kyiv";
            someAddress.Street = "Unnamed";
            someAddress.House = 22;
            someAddress.Apartment = 333;

            Console.WriteLine(someAddress.GetAddress());

            Console.ReadKey();
        }
    }
}
