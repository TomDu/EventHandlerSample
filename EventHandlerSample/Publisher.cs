using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandlerSample
{
    class Publisher
    {
        public event EventHandler<CustomEventArgs> RaiseCustomEvent;

        public void DoSomething()
        {
            OnRaiseCustomEvent(new CustomEventArgs("Do something"));
        }

        protected virtual void OnRaiseCustomEvent(CustomEventArgs args)
        {
            EventHandler<CustomEventArgs> handler = RaiseCustomEvent;

            if (handler != null)
            {
                args.Message += String.Format("at {0}", DateTime.Now);
                handler(this, args);
            }
        }
    }
}
