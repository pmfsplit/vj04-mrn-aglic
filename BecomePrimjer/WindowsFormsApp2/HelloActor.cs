using Akka.Actor;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public class HelloActor : ReceiveActor
    {
        int br = 0;
        //Label _label;
        public HelloActor(Label label)
        {
            //_label = label;
            NeLogiranoPonasanje(label);
        }

        private void NeLogiranoPonasanje(Label _label)
        {
            Receive<Start>(x => _label.Text = "Ovdje ce se ispisat rezultat...");
            Receive<Message>(x =>
            {
                br++;
                _label.Text = $"{x.Sadrzaj} {br}";
                Become(() => LogiranoPonasanje(_label));
            });
        }

        private void LogiranoPonasanje(Label _label)
        {
            Receive<Message>(x => _label.Text = "Vec ste logirani...");
            Receive<Logout>(x =>
            {
                _label.Text = "Odlogirani ste";
                Become(() => NeLogiranoPonasanje(_label));
            });
        }

        protected override void Unhandled(object message)
        {
            System.Diagnostics.Debug.WriteLine(message);
            base.Unhandled(message);
        }
    }
}
