using System;
using Akka.Actor;

namespace DeatchWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var system = ActorSystem.Create("deathwatch"))
            {
                var props = Props.Create(() => new ParentActor());

                var actor1 = system.ActorOf(props, "Marin");
                var actor2 = system.ActorOf(props, "Ante");
                
                actor2.Tell(new Messages.Watch(actor1));
                
                actor1.Tell(new Messages.Explode());
                actor1.Tell(42);
                
                actor1.Tell(PoisonPill.Instance);
                
                system.WhenTerminated.Wait();
            }
        }
    }
}