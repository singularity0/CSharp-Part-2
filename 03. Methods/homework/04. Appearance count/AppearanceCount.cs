using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _04.AppearanceCount
{
    class AppearanceCount
    {
        static void Main(string[] args)
        {
            ArrearanceLogic();
        }

        static void ArrearanceLogic()
        {
            string size = Console.ReadLine();
            string array_entered = Console.ReadLine();
            string number = Console.ReadLine();
            int counter = Regex.Matches(array_entered, number).Count;
            Console.WriteLine(counter);
        }
            
        
    }
}
