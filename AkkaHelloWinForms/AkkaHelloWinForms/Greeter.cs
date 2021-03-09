using Akka.Actor;
using System;
using System.Collections.Generic;
using System.Text;
using AkkaHelloWinForms;
using System.Windows.Forms;

namespace AkkaHelloWinForms
{
    class GreeterActor : ReceiveActor
    {
        public GreeterActor(Label label)
        {
            Receive<Messages.Add>(x => CreateWorker(x));
            Receive<Messages.Write>(x => {
                label.Text = x.Content;
                Sender.Tell(PoisonPill.Instance);
                //Context.Stop(Sender);
            });
        }

        private void CreateWorker(Messages.Add msg)
        {
            var props = Props.Create(() => new ComputationActor());
            var child = Context.ActorOf(props);
            child.Tell(msg);
        }
    }
}
