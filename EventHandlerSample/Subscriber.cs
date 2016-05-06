using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EventHandlerSample
{
    class Subscriber
    {
        private string id;

        public Subscriber(string id, Publisher publisher)
        {
            this.id = id;
            publisher.RaiseCustomEvent += HandleCustomEvent;
        }

        private void HandleCustomEvent(object sender, CustomEventArgs args)
        {
            Console.WriteLine("id: {0}\t{1}", id, args.Message);
            Thread.Sleep(1000);
        }
    }
}
