using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.ForbiddenWirds
{
    class forbiddenWrds
    {
        static void Main(string[] args)
        {
            string[] forbidden = { "Microsoft", "PHP" };
            char symbol = '*';
            string text = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and" +
                            "is implemented as a dynamic language in CLR. PHP CLR Microsoft";
            foreach (var item in forbidden)
            {
                text = text.Replace(item, new string(symbol, item.Length));
            }
            Console.WriteLine(text);

        }
    }
}
