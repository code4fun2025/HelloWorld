using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace WCF_HelloService
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(HelloService));
            host.Open();
            Console.WriteLine("Host Open Sucessfully for Hello World Service...");
            Console.ReadLine();
        }
    }
}
