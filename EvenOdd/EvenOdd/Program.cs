using System;

namespace EvenOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number to check ");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
                Console.WriteLine("Number is Even");
            else
                Console.WriteLine("Number is Odd");
        }

    }
}
