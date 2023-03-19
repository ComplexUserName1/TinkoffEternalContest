using System;

namespace TinkoffTest5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string NumOfEmpAndTime = Console.ReadLine();

            Int32 NumOfEmp = Int32.Parse(NumOfEmpAndTime.Split(' ')[0]);
            Int32 Time = Int32.Parse(NumOfEmpAndTime.Split(' ')[1]);

            string FloorNumbers = Console.ReadLine();

            string[] ArrayFloors = FloorNumbers.Split(' ');
            Int32[] ArrayOfFloors = new Int32[ArrayFloors.Length];

            for (int i = 0; i < ArrayFloors.Length; i++)
                ArrayOfFloors[i] = Int32.Parse(ArrayFloors[i]);

            Int32 ExpEmpNumber = Int32.Parse(Console.ReadLine())-1;

            Int32 MinStairs = ArrayOfFloors[NumOfEmp - 1] - ArrayOfFloors[0];
            Int32 MoveDown = ArrayOfFloors[ExpEmpNumber] - ArrayOfFloors[0];
            Int32 MoveUp = ArrayOfFloors[NumOfEmp - 1] - ArrayOfFloors[ExpEmpNumber];

            if ((MoveDown > Time) && (MoveUp > Time))
            {
                if ((MoveDown) < (MoveUp))
                {
                    MinStairs += MoveDown;
                }
                else
                {
                    MinStairs += MoveUp;
                }
            }

            Console.WriteLine(MinStairs);
        }
    }
}
