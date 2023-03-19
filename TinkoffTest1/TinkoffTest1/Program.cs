using System;

namespace TinkoffTest1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Int32 NumberOfPeople = Int32.Parse(Console.ReadLine());

                if (NumberOfPeople < 1 || NumberOfPeople > 2000000000)
                {
                    Console.WriteLine("The number does not match the task conditions.");
                    return;
                }

                //Math.Log(NumberOfPeople, 2);
                Console.WriteLine(Math.Ceiling(Math.Log(NumberOfPeople, 2)));
            }
            catch(Exception)
            {
                Console.WriteLine("Incorrect input.");
            }
        }
    }
}
