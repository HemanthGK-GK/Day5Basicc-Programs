using System;

namespace PrimeFactor
{
    class PrimeFactor
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number");
            int n = int.Parse(Console.ReadLine());

            primeFactor(n);
             
        }
        public static void primeFactor(int n)
        {
            while(n%2==0)
            {
                Console.Write(2 + " ");
                n /= 2;
            }
            for (int i = 3; i <= Math.Sqrt(n); i += 2)
            {
                while (n % i == 0)
                {
                    Console.Write(i + " ");
                    n /= i;
                }
            }
            if (n > 2)
                Console.Write(n);

        }
    }
}
