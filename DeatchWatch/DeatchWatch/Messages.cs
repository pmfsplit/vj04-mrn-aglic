using Akka.Actor;

namespace DeatchWatch
{
    public class Messages
    {
        public class Watch
        {
            public IActorRef Actor { get; }

            public Watch(IActorRef actor)
            {
                Actor = actor;
            }
        }

        public class Explode { }
    }
}