using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Reverser.UnitTests
{
    [TestClass]
    public class WordReverserTests
    {
        [TestMethod]
        public void GetVerboseMessage_InputsString_ReturnsDetails()
        {
            string inputString = "The quick brown fox";
            WordReverser wordReverser = new WordReverser();
            string outputString = wordReverser.GetVerboseMessage(inputString);

            Assert.AreEqual("Reversing 4 words with 19 letters in total...", outputString);
        }

        [TestMethod]
        public void Execute_InputsSentence_WordsReversed()
        {
            string inputString = "The quick brown fox";
            WordReverser wordReverser = new WordReverser();
            string outputString = wordReverser.Execute(inputString);

            Assert.AreEqual("fox brown quick The", outputString);
        }
    }
}
