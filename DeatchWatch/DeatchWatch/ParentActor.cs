using System;
using Akka.Actor;

namespace DeatchWatch
{
    public class ParentActor : ReceiveActor
    {
        public ParentActor()
        {
            Receive<Messages.Watch>(watch => Context.Watch(watch.Actor));
            Receive<Terminated>(x => Console.WriteLine($"{Self.Path.Name} kaže: " +
                                                       $"{x.ActorRef.Path.Name} je ubijen..."));

            Receive<Messages.Explode>(x => throw new Exception("Exploded!"));
            ReceiveAny(x => Console.WriteLine(x));
        }
    }
}