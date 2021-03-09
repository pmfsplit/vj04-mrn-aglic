using Akka.Actor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AkkaHelloWinForms
{
    public partial class Form1 : Form
    {
        IActorRef actor;

        public Form1()
        {
            InitializeComponent();

            Props props = Props.Create(() => new GreeterActor(label1, label2))
                .WithDispatcher("akka.actor.synchronized-dispatcher");
            actor = Program.System.ActorOf(props);
        }

        private void btnPosaljiPoruku_Click(object sender, EventArgs e)
        {
            actor.Tell(new Messages.Add(5, 4));
        }
    }
}
