using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverser
{
    public interface ICommand
    {
        string GetVerboseMessage(string inputString);
        string Execute(string inputString);
    }
}
