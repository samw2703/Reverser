using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverser
{
    public class Formatter
    {
        private string _inputString;
        private List<ICommand> _commands = new List<ICommand>();
        private bool _verbose = false;
        private DateTime _startTime = new DateTime();

        public Formatter()
        {
        }

        public Formatter(CommandCreator commandCreator)
        {
            _inputString = commandCreator.InputString;
            _commands = commandCreator.Commands;
            _verbose = commandCreator.Verbose;
        }

        public string Run()
        {
            _startTime = DateTime.Now;
            string formatString = _inputString;

            foreach (ICommand command in _commands)
            {
                formatString = command.Execute(formatString);
            }
            return formatString;
        }

        public List<string> GetVerboseStrings()
        {
            if (!_verbose)
                return new List<string>();

            List<string> verboseStrings = new List<string>();
            foreach (ICommand command in _commands)
            {
                verboseStrings.Add(command.GetVerboseMessage(_inputString));
            }
            return verboseStrings;
        }

        public string GetVerboseTimeString()
        {
            if (!_verbose)
                return null;

            return "Completed in " + (DateTime.Now - _startTime).TotalSeconds + " seconds";
        }

        public string OutputUsage()
        {
            return "usage: Reverser.exe input [-l] [-w] [-v]" + Environment.NewLine +
                "Reverses the string inputs" + Environment.NewLine +
                "-l Reverse the letters of each word in the string" + Environment.NewLine +
                "-w Reverse the words in the string" + Environment.NewLine +
                "-v Verbose mode";
        }
    }
}
