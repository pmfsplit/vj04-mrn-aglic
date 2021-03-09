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
        int br = 0;

        public GreeterActor(Label label, Label label2)
        {
            Receive<Messages.Add>(x => CreateWorker(x));
            Receive<Messages.Write>(x => {
                label.Text = x.Content;
                label2.Text = br.ToString();
                Sender.Tell(PoisonPill.Instance);
                //Context.Stop(Sender);
            });
        }

        private void CreateWorker(Messages.Add msg)
        {
            br += 1;
            var props = Props.Create(() => new ComputationActor());
            var child = Context.ActorOf(props);
            child.Tell(msg);
        }
    }
}
