using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalDecorator
{
    class SignalEncryptorDecorator : Signal
    {
        ///<summary>Genegates new message and encrypts it</summary>
        public SignalEncryptorDecorator()
        {
            string input = message;
            message = "";

            foreach (char c in input.ToArray())
            {
                message += Convert.ToChar(c * 2);
            }
        }

        ///<summary>Ecrypts message from input Signal</summary>
        public SignalEncryptorDecorator(Signal _s)
        {
            string input = _s.Message;
            message = "";

            foreach (char c in input.ToArray())
            {
                message += Convert.ToChar(c * 2);
            }

        }
    }
}
