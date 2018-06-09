using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 4;
            UpdateRefInt(ref i);
            Console.WriteLine(i);
            Console.ReadKey();
        }

        private static void UpdateRefInt(ref int i)
        {
            i = 8;
        }
    }
}
