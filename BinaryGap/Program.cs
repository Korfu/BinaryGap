using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryGap
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program caluclates maximum binary gap for a given number.");
            Console.WriteLine("Please enter the number");

            int intNumber = Int32.Parse(Console.ReadLine());
            string binaryNumber = Convert.ToString(intNumber, 2);
            Console.WriteLine($"Your number is {intNumber} and it's binary representation is {binaryNumber}. ");

            var result = Solution.Gap(binaryNumber);
            Console.WriteLine("Binary gap is: " +result);
            Console.ReadLine();
        }
    }
}
