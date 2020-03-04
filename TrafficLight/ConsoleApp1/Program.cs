using System;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("STOP");
            Thread.Sleep(1500);

            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("READY");
            Thread.Sleep(1500);

            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("GO!");

            Console.ReadLine();



            
        }
    }
}
