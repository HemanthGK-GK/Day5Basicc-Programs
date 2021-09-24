using System;

namespace SwapNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number1");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a number2");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Before swapping");
            Console.WriteLine("Number1 : "+num1);
            Console.WriteLine("Number2 : " + num2);

            int temp = 0;
            temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine("After swapping");
            Console.WriteLine("Number1 : " + num1);
            Console.WriteLine("Number2 : " + num2);

        }
    }
}
