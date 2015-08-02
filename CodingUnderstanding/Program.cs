using CodingUnderstanding.Generics;
using System;

namespace CodingUnderstanding
{
    class Program
    {
        static void Main(string[] args)
        {
            NonGenericExample nga = new NonGenericExample();

            GenericExample ga = new GenericExample();

            Console.WriteLine("Press Any key...");
            Console.ReadLine();
        }
    }
}
