using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverser
{
    public class LetterReverser : ICommand
    {
        public string GetVerboseMessage(string inputString)
        {
            return "Reversing sentence with " + inputString.Length + " letters in total...";
        }

        public string Execute(string inputString)
        {
            List<string> inputStringList = inputString.Split(null).ToList();
            string outputString = "";

            foreach (string word in inputStringList)
            {
                outputString += word.Reverse() + " ";
            }
            return outputString.TrimEnd();
        }
    }
}
