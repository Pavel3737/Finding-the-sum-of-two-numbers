using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Say("Hello world!");
            Console.WriteLine(Sum(2, 4));
        }

        static void Say(string str)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(str);
            }
        }

        static int Sum(int a, int b)
        {
            int c = a + b;
            return c;
        }
    }
}