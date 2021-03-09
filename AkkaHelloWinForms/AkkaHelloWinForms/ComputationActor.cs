using System;
using System.Collections.Generic;
using System.Text;
using Akka.Actor;

namespace AkkaHelloWinForms
{
    class ComputationActor : ReceiveActor
    {
        public ComputationActor()
        {
            Receive<Messages.Add>(x =>
            Sender.Tell(new Messages.Write((x.A + x.B).ToString())));
        }
    }
}
