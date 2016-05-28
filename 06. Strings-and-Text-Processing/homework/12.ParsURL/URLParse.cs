using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.ParsURL
{
    class URLParse
    {
        static void Main(string[] args)
        {
            string url = Console.ReadLine();
            string[] split = url.Split(new string[] { "://" }, StringSplitOptions.RemoveEmptyEntries);
            string protocol = "[protocol] = " + split[0];
            string server = "[server] = " + split[1].Substring(0, split[1].IndexOf('/'));
            string uri = "[resource] = " + split[1].Substring(split[1].IndexOf('/'));
            Console.WriteLine("{0}\n{1}\n{2}", protocol, server, uri);
        }
    }
}
