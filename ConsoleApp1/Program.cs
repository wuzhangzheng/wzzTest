using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //ref and out 区别
            
            int i = 4;
            UpdateRefInt(ref i);
            string str;
            UpdateOutStr(out str);
            Console.WriteLine(str);
            Console.ReadKey();
        }

        private static void UpdateOutStr(out string str)
        {
            str = "hello world";
        }

        private static void UpdateRefInt(ref int i)
        {
            i = 8;
        }
    }
}
