using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Reverser.UnitTests
{
    [TestClass]
    public class LetterReverserTests
    {
        [TestMethod]
        public void GetVerboseMessage_InputsString_ReturnsDetails()
        {
            string inputString = "The quick brown fox";
            LetterReverser letterReverser = new LetterReverser();
            string outputString = letterReverser.GetVerboseMessage(inputString);

            Assert.AreEqual("Reversing sentence with 19 letters in total...", outputString);
        }

        [TestMethod]
        public void Execute_InputsSentence_LettersOfWordsReversed()
        {
            string inputString = "The quick brown fox";
            LetterReverser letterReverser = new LetterReverser();
            string outputString = letterReverser.Execute(inputString);

            Assert.AreEqual("ehT kciuq nworb xof", outputString);
        }
    }
}
