using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WsHttpBinding.Client.First
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloWorldClient worldClient = new HelloWorldClient("WSHttpBinding_IHelloWorld");
            string notes = worldClient.GetWelcomeNotesAsync().Result;

            //HelloWorldClient helloWorld = new HelloWorldClient("WSHttpBinding_IHelloWorld1");
            //string notes1 = helloWorld.GetWelcomeNotesAsync().Result;

            //HelloWorldClient helloWorldClient = new HelloWorldClient("WSHttpBinding_IHelloWorld1");
            //string notes2 = helloWorldClient.GetWelcomeNotesAsync().Result;
        }
    }
}
