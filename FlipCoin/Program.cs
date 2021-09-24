using System;

namespace FlipCoin
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Enter the number of Flip a coin");
            int NumFlip = int.Parse(Console.ReadLine());

            int Head = 0;
            int Tail = 0;
            int HeadP = 0;
            int TailP = 0;

            Random random = new Random();

            for (int i = 0; i < NumFlip; i++)
            {
                int flip = random.Next(0, 2);

                Console.WriteLine("The Coin flip is : " + flip);

                if (flip == 1)
                    Head = Head + 1;
                else
                    Tail++;

            }
            Console.WriteLine("Headcount is : " + Head);
            Console.WriteLine("Tailcount is : " + Tail);
            HeadP = ((Head * 100) / NumFlip);
            TailP = ((Tail * 100) / NumFlip);

            Console.WriteLine("Head Percentage is : " + HeadP);
            Console.WriteLine("Tail Percentage is : " + TailP);


        }
    }
}
