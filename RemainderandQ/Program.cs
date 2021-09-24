using System;

namespace RemainderandQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Devider ");
            int div = int.Parse(Console.ReadLine());

             Console.WriteLine("Remainder : "+ num % div);
            Console.WriteLine("Quotient : " + num / div);


        }
    }
}
