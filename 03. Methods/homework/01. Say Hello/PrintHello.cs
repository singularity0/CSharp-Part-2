using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.PrintHello
{
    class PrintHello
    {
        static void Main(string[] args)
        {
            PrintUserName();
        }
        public static string RequestUserName()
        {
            return Console.ReadLine();
        }
        static void PrintUserName()
        {
            Console.WriteLine("Hello, {0}!", RequestUserName());
        }
    }
}
