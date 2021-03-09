using Akka.Actor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vj04_LifeCycle_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var actorSystem = ActorSystem.Create("Kenny"))
            {
                Props props = Props.Create(() => new KennyActor(27));

                IActorRef kenny = actorSystem.ActorOf(props);

                kenny.Tell(1);
                kenny.Tell("Hello kenny");
                kenny.Tell(new Explode());
                kenny.Tell("you okay kenny?");
                kenny.Tell(PoisonPill.Instance);

                // actorSystem.Stop(kenny);
                
                actorSystem.WhenTerminated.Wait();
            }
        }
    }
}
