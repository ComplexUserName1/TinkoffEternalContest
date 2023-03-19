using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;

namespace TinkoffTest2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Conditions = Console.ReadLine();
            Int32 AmountOfNumbers = Convert.ToInt32(Conditions.Split(' ')[0]);
            Int32 NumberOfOperations = Convert.ToInt32(Conditions.Split(' ')[1]);

            string Numbers = Console.ReadLine();
            string[] ArrayNumbers = Numbers.Split(' ');

            List<Int64> Delta = new List<Int64>();
            Int64 Number = 0;

            for (int i = 0; i < AmountOfNumbers; i++)
            {
                Number = Convert.ToInt32(ArrayNumbers[i]);

                Int32 Weight = 1;

                while (Number > 0)
                {

                    Delta.Add((9 - (Number % 10)) * Weight);
                    Weight *= 10;
                    Number /= 10;
                }
            }

            Delta.Sort();
            Delta.Reverse();

            Int64 Sum = 0;

            for (int i = 0; i < NumberOfOperations && i < Delta.Count; i++)
            {
                Sum += Delta[i];
            }

            Console.WriteLine(Sum);
        }
    }
}
