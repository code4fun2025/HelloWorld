using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCF_HelloConsumer.Proxy_Hello;

namespace WCF_HelloConsumer
{
    class Program
    {
        static void Main(string[] args)
        {
            Proxy_Hello.HelloServiceClient proxy = new HelloServiceClient("BasicHttpBinding_IHelloService");
            string str = proxy.HelloMessage();
            Console.WriteLine(" Got Message from HelloService:" + str);
            Console.ReadLine();
        }
    }
}
