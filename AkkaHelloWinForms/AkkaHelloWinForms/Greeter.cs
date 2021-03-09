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
            Receive<Messages.Write>(x => label.Text = x.Content);
        }
    }
}
