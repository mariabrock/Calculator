using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a series of numbers seperated by a comma. Please list them in the order you would like them to be multiplied in.");
            string userNumbers = Console.ReadLine();
            string[] splitNumbers = userNumbers.Split(',');
            //now loop through numbers and multiply together
            int numSequence = 1;
            foreach (var number in splitNumbers)
            {
                int num = int.Parse(number);
                numSequence *= num;
            }
            Console.WriteLine(numSequence);

            Console.ReadKey();
        }
    }
}
