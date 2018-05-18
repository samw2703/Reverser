using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Reverser.UnitTests
{
    [TestClass]
    public class FormatterTests
    {
        [TestMethod]
        public void Run_NoFlags_ReturnsString()
        {
            List<string> arguments = new List<string> { "The quick brown fox" };
            CommandCreator commandCreator = new CommandCreator(arguments);
            Formatter formatter = new Formatter(commandCreator);

            Assert.AreEqual("The quick brown fox", formatter.Run());
        }

        [TestMethod]
        public void Run_LetterFlag_ReturnsStringWordLettersReversed()
        {
            List<string> arguments = new List<string> { "-l", "The quick brown fox" };
            CommandCreator commandCreator = new CommandCreator(arguments);
            Formatter formatter = new Formatter(commandCreator);

            Assert.AreEqual("ehT kciuq nworb xof", formatter.Run());
        }

        [TestMethod]
        public void Run_WordFlag_ReturnsStringWordsReversed()
        {
            List<string> arguments = new List<string> { "-w", "The quick brown fox" };
            CommandCreator commandCreator = new CommandCreator(arguments);
            Formatter formatter = new Formatter(commandCreator);

            Assert.AreEqual("fox brown quick The", formatter.Run());
        }

        [TestMethod]
        public void Run_BothFlags_ReturnsStringWordsAndLettersReversed()
        {
            List<string> arguments = new List<string> { "-l", "-w", "The quick brown fox" };
            CommandCreator commandCreator = new CommandCreator(arguments);
            Formatter formatter = new Formatter(commandCreator);

            Assert.AreEqual("xof nworb kciuq ehT", formatter.Run());
        }

        [TestMethod]
        public void GetVerboseStrings_VerboseFalse_ReturnEmptyList()
        {
            List<string> arguments = new List<string> { "The quick brown fox" };
            CommandCreator commandCreator = new CommandCreator(arguments);
            Formatter formatter = new Formatter(commandCreator);
            List<string> outputStringList = formatter.GetVerboseStrings();

            Assert.AreEqual(0, outputStringList.Count);
        }

        [TestMethod]
        public void GetVerboseStrings_VerboseTrueNoFlags_ReturnEmmptyList()
        {
            List<string> arguments = new List<string> { "-v", "The quick brown fox" };
            CommandCreator commandCreator = new CommandCreator(arguments);
            Formatter formatter = new Formatter(commandCreator);
            List<string> outputStringList = formatter.GetVerboseStrings();

            Assert.AreEqual(0, outputStringList.Count);
        }

        [TestMethod]
        public void GetVerboseStrings_VerboseTrueLettersFlag_ReturnLettersVerboseString()
        {
            List<string> arguments = new List<string> { "-v", "-l", "The quick brown fox" };
            CommandCreator commandCreator = new CommandCreator(arguments);
            Formatter formatter = new Formatter(commandCreator);
            List<string> outputStringList = formatter.GetVerboseStrings();

            Assert.AreEqual(1, outputStringList.Count);
            Assert.AreEqual("Reversing sentence with 19 letters in total..." , outputStringList[0]);
        }

        [TestMethod]
        public void GetVerboseStrings_VerboseTrueWordsFlag_ReturnWordsVerboseString()
        {
            List<string> arguments = new List<string> { "-v", "-w", "The quick brown fox" };
            CommandCreator commandCreator = new CommandCreator(arguments);
            Formatter formatter = new Formatter(commandCreator);
            List<string> outputStringList = formatter.GetVerboseStrings();

            Assert.AreEqual(1, outputStringList.Count);
            Assert.AreEqual("Reversing 4 words with 19 letters in total...", outputStringList[0]);
        }

        [TestMethod]
        public void GetVerboseStrings_VerboseTrueBothFlags_ReturnBothVerboseStrings()
        {
            List<string> arguments = new List<string> { "-v", "-l", "-w", "The quick brown fox" };
            CommandCreator commandCreator = new CommandCreator(arguments);
            Formatter formatter = new Formatter(commandCreator);
            List<string> outputStringList = formatter.GetVerboseStrings();

            Assert.AreEqual(2, outputStringList.Count);
            Assert.AreEqual("Reversing sentence with 19 letters in total...", outputStringList[0]);
            Assert.AreEqual("Reversing 4 words with 19 letters in total...", outputStringList[1]);
        }

        [TestMethod]
        public void GetVerboseTimeString_VerboseFalse_ReturnNull()
        {
            List<string> arguments = new List<string> { "The quick brown fox" };
            CommandCreator commandCreator = new CommandCreator(arguments);
            Formatter formatter = new Formatter(commandCreator);

            Assert.IsNull(formatter.GetVerboseTimeString());
        }

        [TestMethod]
        public void GetVerboseTimeString_VerboseTrue_ReturnsAString()
        {
            List<string> arguments = new List<string> { "-v", "The quick brown fox" };
            CommandCreator commandCreator = new CommandCreator(arguments);
            Formatter formatter = new Formatter(commandCreator);

            Assert.IsNotNull(formatter.GetVerboseTimeString());
        }

    }
}
