using System;

namespace LargeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number :");
           int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter Second number :");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("Enter Third number :");
            int num3 = int.Parse(Console.ReadLine());

            if(num1>num2 && num1>num3)
                Console.Write("The Greater Number is : "+num1);
            else if (num2 > num1 && num2 > num3)
                Console.Write("The Greater Number is : " + num2);
            else
                Console.Write("The Greater Number is : " + num3);
        }
    }
}
