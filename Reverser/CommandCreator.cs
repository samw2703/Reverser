using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverser
{
    public class CommandCreator
    {
        public string InputString { get; }
        public bool Verbose { get; }
        public List<ICommand> Commands { get; }

        public CommandCreator(List<String> arguments)
        {
            InputString = arguments.Last();
            Commands = new List<ICommand>();
            Verbose = false;
            List<string> flagList = arguments.GetRange(0, arguments.Count - 1);

            foreach (string flag in flagList)
            {
                switch (flag.ToLower())
                {
                    case "-w":
                        Commands.Add(new WordReverser());
                        break;
                    case "-l":
                        Commands.Add(new LetterReverser());
                        break;
                    case "-v":
                        Verbose = true;
                        break;
                    default:
                        throw new ArgumentException(flag + " is not a valid argument");
                }
            }
        }
    }
}
