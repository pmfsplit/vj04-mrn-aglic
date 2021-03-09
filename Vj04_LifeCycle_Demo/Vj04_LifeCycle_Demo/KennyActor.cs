using Akka.Actor;
using System;
using System.Threading;

namespace Vj04_LifeCycle_Demo
{
    class KennyActor : ReceiveActor
    {
        private int id;

        public KennyActor(int id)
        {
            this.id = id;
            
            Console.WriteLine("OVO JE IZ KONSTRUKTORA");

            /* Redoslijed kojim registriramo handlere za poruke je vazan!!*/
            Receive<Explode>(x => HandleExplode());
            ReceiveAny(x =>
            {
                Console.WriteLine($"{DateTime.Now} - {x}");
            });
        }

        private void HandleExplode()
        {
            throw new Exception("OMG THEY KILLED KENNY!!!!!");
        }

        protected override void PreStart()
        {
            Console.WriteLine($"Kenny (${this.id}) prestart method called... my path: {Self.Path}");
            base.PreStart();
        }
        
        protected override void PostStop()
        {
            Console.WriteLine("Kenny poststop method called...");
            base.PostStop();
        }
        
        protected override void PreRestart(Exception reason, object message)
        {
            Console.WriteLine($"Kenny prerestart method called: {message}: {reason}");
            base.PreRestart(reason, message);
        }
        
        protected override void PostRestart(Exception reason)
        {
            Console.WriteLine($"Kenny postrestart method called...{reason}");
            base.PostRestart(reason);
        }
    }
}
