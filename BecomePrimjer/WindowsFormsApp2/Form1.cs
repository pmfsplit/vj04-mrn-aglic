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

namespace WindowsFormsApp2
{

    public partial class Form1 : Form
    {
        IActorRef _actor;
        public Form1()
        {
            InitializeComponent();

            Props props = Props.Create(() => new HelloActor(lbl))
                .WithDispatcher("akka.actor.synchronized-dispatcher");

            _actor = Program.System.ActorOf(props);
            _actor.Tell(new Start());
        }

        private void btnPosalji_Click(object sender, EventArgs e)
        {
            _actor.Tell(new Message("Logirani ste"));
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            _actor.Tell(new Logout());
        }
    }
}
