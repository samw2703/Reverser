using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Reverser.UnitTests
{
    [TestClass]
    public class StringExtensionsTest
    {
        [TestMethod]
        public void Reverse_InputsString_ReturnsReversedString()
        {
            string inputString = "abcdefghijklmnopqrstuvwxyz";
            string outputString = inputString.Reverse();

            Assert.AreEqual("zyxwvutsrqponmlkjihgfedcba", outputString);
        }
    }
}
