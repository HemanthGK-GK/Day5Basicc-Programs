using System;

namespace Powerof2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1, power = 1;
            Console.WriteLine("Enter Number Between 2 to 30");
            int num = int.Parse(Console.ReadLine());

            while(i<=num)
            {
                Console.WriteLine(i + " " + power);
                power = 2 * power;
                i++;
            }


        }
    }
}
