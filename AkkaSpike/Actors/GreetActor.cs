using Akka.Actor;
using AkkaSpike.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkkaSpike.Actors
{
    public class GreetActor : ReceiveActor
    {
        public GreetActor()
        {
            Receive<Greet>(greet => 
               Console.WriteLine("The program says '{0}'", greet.Message));
        }
    }
}
