using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Reverser.UnitTests
{
    [TestClass]
    public class CommandCreatorTests
    {

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CommandCreator_ErroneousFlag_ThrowsException()
        {
            List<string> argsList = new List<string>(new string[] { "-q", "The quick brown fox" });
            CommandCreator commandCreator = new CommandCreator(argsList);
        }
    }
}
