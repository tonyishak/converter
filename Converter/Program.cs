using System;

namespace Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Title: ConverterApp");
            Console.WriteLine("Description: Will convert yards to inches");
            Console.WriteLine("Please enter the number of yards:");

            int numYards = int.Parse(Console.ReadLine());
            int numInches = numYards * 36;
            Console.WriteLine("Number of inches in " + numYards + " yards is " + numInches + " inches");
            Console.ReadLine();

        }
    }
}
