using System;
using System.Data;
using System.Linq;
using System.Numerics;

namespace TinkoffTest6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Constraints = Console.ReadLine();

            ulong Start = ulong.Parse(Constraints.Split(' ')[0]);
            ulong End = ulong.Parse(Constraints.Split(' ')[1]);

            Console.WriteLine(get_number_tests(Start, End));
        }

        static double get_number_tests(ulong l, ulong r)
        {
            Int64[] Allowed = new Int64[10];
            for (int x = 0; x < 10; x++)
            {
                Allowed[x] = x;
            }

            Int64 amount_of_tests = 0;

            Int32 left_border = l.ToString().Length;
            Int32 right_border = r.ToString().Length;

            for (Int32 Item = left_border; Item <= right_border; Item++)
            {
                foreach (Int64 Num in Allowed)
                {
                    ulong curent_number = ulong.Parse(new String(Char.Parse(Num.ToString()), Item));

                    if (curent_number >= l && curent_number <= r)
                        amount_of_tests += 1;
                }
            }

            return amount_of_tests;
        }
    }
}