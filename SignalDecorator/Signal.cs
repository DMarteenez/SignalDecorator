using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalDecorator
{
    class Signal
    {
        
        protected string message;

        public string Message { get => message; }

        ///<summary>Genegates message</summary>
        public Signal()
        {
            message = DateTime.Now.ToString();
        }         
    }
}
