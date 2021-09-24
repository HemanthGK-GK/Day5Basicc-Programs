using System;

namespace VowelOrNote
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an Alphabet to check Vowel or Consonant ");
            char alpha = Convert.ToChar(Console.ReadLine());

            if (alpha ==  'a'|| alpha == 'e' || alpha == 'i' || alpha == 'o' || alpha == 'u' ||
                alpha == 'A' || alpha == 'E' ||alpha == 'I' || alpha == 'O' || alpha == 'U' ||)
            {
                Console.WriteLine(alpha + " Is a Vowel");
            }
            else
                Console.WriteLine(alpha + " Is Consonent");
        }
    }
}
