using System;
using System.Reflection;

namespace TinkoffTest4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Int64 LimitSumCoins = Int32.Parse(Console.ReadLine());

            string SumCoins = Console.ReadLine();
            string[] ArrayCoins = SumCoins.Split(' ');

            Int32[] ArrayOfCoins = new Int32[ArrayCoins.Length];

            for (int i = 0; i < ArrayCoins.Length; i++)
            {
                ArrayOfCoins[i] = Int32.Parse(ArrayCoins[i]);
            }

            Console.WriteLine(countCombinations(LimitSumCoins, ArrayOfCoins, 0));
        }

        static Int64 countCombinations(Int64 LimitSumCoins, Int32[] ArrayOfCoins, Int32 Index)
        {
            Int64 combinationsCount = 0;

            if (LimitSumCoins < 1)
            {
                return combinationsCount;
            }

            combinationsCount++;

            for (int i = Index; i < ArrayOfCoins.Length; i++)
            {
                combinationsCount += countCombinations(LimitSumCoins - ArrayOfCoins[Index], ArrayOfCoins, Index);
                Index++;
            }

            return combinationsCount;
        }
    }
}
