using System;

namespace NumbersSumRandom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            string savedNumbers = "";
            int sumNumbers = 0;
            int number;
            int minRandomNumber = 0;
            int maxRandomNumber = 100;
            int FirstMultipelNumber = 3;
            int SecondmultipeNumber = 5;

            number = random.Next(minRandomNumber, maxRandomNumber);

            for (int i = number; i >= 0; i--)
            {
                if (i % FirstMultipelNumber == 0 || i % SecondmultipeNumber == 0)
                {
                    savedNumbers += Convert.ToString(i) + " ";
                    sumNumbers += i;
                }
            }

            Console.WriteLine(number);
            Console.WriteLine(savedNumbers);
            Console.WriteLine(sumNumbers);
            Console.ReadKey();
        }
    }
}
