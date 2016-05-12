using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrequentNumber
{
    class FreqNum
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            Dictionary<int, int> freqs = new Dictionary<int, int>();
            for (int i = 0; i < size; i++)
            {
                int element = int.Parse(Console.ReadLine());
                if (freqs.ContainsKey(element))
                {
                    freqs[element] += 1;
                }
                else
                {
                    freqs[element] = 1;
                }
            }

            int counter = 0;
            int most_freq = 0;
            foreach (var item in freqs)
            {
                if (item.Value > counter)
                {
                    counter = item.Value;
                    most_freq = item.Key;
                }
            }

            Console.WriteLine("{0} ({1} times)", most_freq,  counter);


        }
    }
}
