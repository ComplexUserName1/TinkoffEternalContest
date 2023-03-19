using System;
using System.Collections.Generic;
using System.Linq;

namespace TinkoffTest3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Int32 NumOfStudents = Int32.Parse(Console.ReadLine());

            string StudentsHeights = Console.ReadLine();
            string[] ArrayStudentsHeights = StudentsHeights.Split(' ');

            Int32[] ArrayOfStudentsHeights = new Int32[NumOfStudents];

            List<Int32> even_stack = new List<Int32>();
            List<Int32> odd_stack = new List<Int32>();

            for (int i = 0; i < ArrayOfStudentsHeights.Length; i++)
            {
                ArrayOfStudentsHeights[i] = Int32.Parse(ArrayStudentsHeights[i]);
                if ((i + ArrayOfStudentsHeights[i]) % 2 == 0)
                {
                    if (ArrayOfStudentsHeights[i] % 2 == 0)
                        even_stack.Add(i);
                    else
                        odd_stack.Add(i);
                }
            }

            if (even_stack.Count == 1 && odd_stack.Count == 1)
                Console.WriteLine((even_stack[0] + 1) + " " + (odd_stack[0] + 1));
            else if (even_stack.Count == 0 && odd_stack.Count == 0 && ArrayOfStudentsHeights.Length >= 3)
                Console.WriteLine("1 3");
            else Console.WriteLine("-1 -1");
        }
    }
}
