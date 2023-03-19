using System;
using System.Collections.Generic;

namespace TinkoffTest7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Int32 NumOfStudents = Int32.Parse(Console.ReadLine());

            string Students = Console.ReadLine();
            string[] ArrayStudents = Students.Split(' ');

            List<Int32> ArrayOfStudents = new List<Int32>();

            for (int i = 0; i < NumOfStudents; i++)
            {
                ArrayOfStudents.Add(Int32.Parse(ArrayStudents[i]));
            }

            if (cycleCheck(ArrayOfStudents))
            {
                Console.WriteLine("-1 -1");
                return;
            }

            IDictionary<Int32, List<Int32>> relationshipMap = new Dictionary<Int32, List<Int32>>();
            for (int i = 0; i < ArrayOfStudents.Count; i++)
            {
                relationshipMap.Add(i + 1, new List<Int32>());
            }

            for (int i = 0; i < ArrayOfStudents.Count; i++)
            {
                relationshipMap[ArrayOfStudents[i]].Add(i + 1);
            }

            List<Int32> stWithoutRelship = new List<Int32>();
            List<Int32> stWithDoubleRelship = new List<Int32>();

            foreach(KeyValuePair<Int32, List<Int32>> map in relationshipMap)
            {
                if (map.Value.Count == 0)
                    stWithoutRelship.Add(map.Key);

                if (map.Value.Count == 2)
                {
                    stWithDoubleRelship.Add(map.Value[0]);
                    stWithDoubleRelship.Add(map.Value[1]);
                }
            }

            if (!(stWithoutRelship.Count == 1 && stWithDoubleRelship.Count == 2))
            {
                Console.WriteLine("-1 -1");
                return;
            }

            Int32 save = ArrayOfStudents[stWithDoubleRelship[0] - 1];
            ArrayOfStudents[stWithDoubleRelship[0] - 1] = stWithoutRelship[0];
            if (cycleCheck(ArrayOfStudents))
            {
                Console.WriteLine(stWithDoubleRelship[0] + " " + stWithoutRelship[0]);
                return;
            }

            ArrayOfStudents[stWithDoubleRelship[0] - 1] =  save;
            ArrayOfStudents[stWithDoubleRelship[1] - 1] = stWithoutRelship[0];
            if (cycleCheck(ArrayOfStudents))
            {
                Console.WriteLine(stWithDoubleRelship[1] + " " + stWithoutRelship[0]);
                return;
            }

            Console.WriteLine("-1 -1");
        }

        private static bool cycleCheck(List<Int32> list)
        {
            HashSet<Int32> set = new HashSet<Int32>();
            int num = 1;

            for (int i = 0; i < list.Count; i++)
            {
                num = list[num - 1];
                set.Add(num);
            }

            return list.Count == set.Count;
        }
    }
}
