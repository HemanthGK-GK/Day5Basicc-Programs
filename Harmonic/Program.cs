using System;

namespace Harmonic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int Num = int.Parse(Console.ReadLine());
            Console.Write(1);
            for(int i=1;i<=Num;i++)
            {
                Console.Write(" + 1/"+i);
            }
        }
    }
}
