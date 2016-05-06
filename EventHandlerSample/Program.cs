using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandlerSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Publisher publisher = new Publisher();
            Subscriber subscriber1 = new Subscriber("foo", publisher);
            Subscriber subscriber2 = new Subscriber("bar", publisher);

            publisher.DoSomething();
        }
    }
}
