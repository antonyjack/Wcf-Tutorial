﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WsHttpBinding.First.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "HelloWorld" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select HelloWorld.svc or HelloWorld.svc.cs at the Solution Explorer and start debugging.
    public class HelloWorld : IHelloWorld
    {
        public string GetWelcomeNotes()
        {
            return "Hello World";
        }
    }
}
