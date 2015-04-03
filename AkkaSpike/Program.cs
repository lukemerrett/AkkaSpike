using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Akka;
using Akka.Actor;
using AkkaSpike.Actors;
using AkkaSpike.Messages;

namespace AkkaSpike
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            // Create a new actor system (a container for your actors)
            var system = ActorSystem.Create("GreetingSystem");

            // Create your actor and get a reference to it.
            // This will be an "ActorRef", which is not a reference to the actual actor instance but rather a client or proxy to it.
            var greeter = system.ActorOf<GreetActor>("Greeter");

            var greet = new Greet
            {
                Message = "Hello there"
            };

            // Send a message to the actor
            greeter.Tell(greet);

            Console.ReadLine();
        }
    }
}
