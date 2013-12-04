using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DnsResolve
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                IPHostEntry hostInfo = Dns.GetHostEntry(args[0]);
                Console.WriteLine(hostInfo.AddressList[0]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
