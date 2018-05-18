using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverser
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                if (args.Length == 0)
                    throw new Exception("Please provide a string");

                CommandCreator commandCreator = new CommandCreator(args.ToList());
                Formatter formatter = new Formatter(commandCreator);

                List<string> verboseStrings = formatter.GetVerboseStrings();
                foreach (string verboseString in verboseStrings)
                {
                    Console.WriteLine(verboseStrings);
                }
                Console.WriteLine(formatter.Run());
                string verboseTimeString = formatter.GetVerboseTimeString();
                if (!string.IsNullOrEmpty(verboseTimeString))
                    Console.WriteLine(verboseTimeString);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Formatter formatter = new Formatter();
                Console.WriteLine(formatter.OutputUsage());
            }
        }
    }
}
