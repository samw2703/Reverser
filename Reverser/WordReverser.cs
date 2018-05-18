using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverser
{
    public class WordReverser : ICommand
    {
        public string GetVerboseMessage(string inputString)
        {
            return "Reversing " + inputString.Split(null).Count() + " words with " + inputString.Length + " letters in total...";
        }

        public string Execute(string inputString)
        {
            List<string> inputStringList = inputString.Split(null).ToList();
            string outputString = "";

            inputStringList.Reverse();
            foreach (string word in inputStringList)
            {
                outputString += word + " ";
            }
            return outputString.TrimEnd();
        }
    }
}
