using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersSumRandom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            string savedNumbers = "";
            int sumNumbers = 0;
            int number;
            int multipelThree = 3;
            int multipelFive = 5;

            number = rand.Next(0, 100);

            for (int i = number; i >= 0; i--) { 
                if(i % multipelThree == 0 || i % multipelFive == 0)
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
