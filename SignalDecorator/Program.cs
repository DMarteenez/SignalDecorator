using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalDecorator
{
    class Program
    {
        static void Main(string[] args)

        {
            Signal s = new Signal();

            Console.WriteLine("Message: " + s.Message);
            Console.WriteLine();

            Console.WriteLine("Enter message handling method: ");
            Console.WriteLine("(Use 'n' for none, 'e' for Encryption, 'c' for Compression, 'b' for both or enter full method name)");

            string type = Console.ReadLine();

            switch (type)
            {
                case "n":
                    type = "none";
                    break;
                case "e":
                    type = "encryption";
                    break;
                case "c":
                    type = "compression";
                    break;
                case "b":
                    type = "both";
                    break;
            }

            Console.WriteLine();

            try
            {
                switch (type.ToLower())
                {
                    case "none":
                        break;
                    case "encryption":
                        s = new SignalEncryptorDecorator(s);
                        break;
                    case "compression":
                        s = new SignalCompressorDecorator(s);
                        break;
                    case "both":
                        s = new SignalEncryptorDecorator(new SignalCompressorDecorator(s));
                        break;
                    default:
                        throw new Exception(message: "Wrong message handling method.");
                }

                Console.WriteLine(s.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                if (e.InnerException != null)
                {
                    Console.WriteLine(e.InnerException.Message);
                }
            }


            Console.ReadKey();
        }
    }
}
