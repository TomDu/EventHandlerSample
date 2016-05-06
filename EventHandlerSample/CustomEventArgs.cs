using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandlerSample
{
    class CustomEventArgs : EventArgs
    {
        private string message;

        public string Message
        {
            get { return message; }
            set { message = value; }
        }
        public CustomEventArgs(string str)
        {
            message = str;
        }
    }
}
