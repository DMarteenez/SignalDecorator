using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalDecorator
{
    class SignalCompressorDecorator : Signal
    {
        ///<summary>Genegates new message and compresses it</summary>
        public SignalCompressorDecorator()
        {
            string input = message;

            message = new string(input.Where(c => char.IsDigit(c)).ToArray());
        }

        ///<summary>Compresses message from input Signal</summary>
        public SignalCompressorDecorator(Signal _s)
        {
            string input = _s.Message;

            message = new string(input.Where(c => char.IsDigit(c)).ToArray());
        }
    }
}
