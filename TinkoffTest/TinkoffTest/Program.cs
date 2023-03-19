using System;
using System.IO;
using System.Linq;

namespace TinkoffTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //string path = @"F:\TinkoffTest\numbers.txt";

                string num = Console.ReadLine();

                string[] numbers = num.Split(' ');

                //using (StreamReader reader = new StreamReader(path))
                //{
                //    numbers = reader.ReadToEnd().Split(' ');
                //}

                if (numbers.Length > 7)
                {
                    Console.WriteLine("The input data file does not satisfy the task conditions.");
                    return;
                }

                Int32[] arrayOfNumbers = new Int32[4];

                Int32 b = 0;

                for (int i = 0; i < numbers.Length; i++)
                {
                    if (Int32.TryParse(numbers[i], out Int32 number))
                    {
                        arrayOfNumbers[b] = number;
                        b++;
                    }
                }

                int A = arrayOfNumbers[0];
                int B = arrayOfNumbers[1];
                int C = arrayOfNumbers[2];
                int D = arrayOfNumbers[3];

                if (!(Enumerable.Range(1, 100).Contains(A)) ||
                    !(Enumerable.Range(1, 100).Contains(B)) ||
                    !(Enumerable.Range(1, 100).Contains(C)) ||
                    !(Enumerable.Range(1, 100).Contains(D)))
                {
                    Console.WriteLine("You have a number that goes beyond the allowed range of input numbers (1-100). Check your file.");
                    return;
                }

                if (D > B)
                {
                    Console.WriteLine(A + C * (D - B));
                }
                else Console.WriteLine(A);
            }
            catch(Exception)
            {
                Console.WriteLine("The input data file does not satisfy the task conditions.");
                return;
            }
        }
    }
}
