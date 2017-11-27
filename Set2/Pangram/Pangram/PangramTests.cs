/*Un panagram e o frază care conține toate literele din alfabet (englezesc).
Scrie un program care determină dacă o frază e o panagram.*/

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Pangram
{
    [TestClass]
    public class PangramTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(true, IsPangram("The quick brown fox jumps over the lazy dog"));
            Assert.AreEqual(true, IsPangram("abcdefghijklmnopqrstuvwxyz"));
            Assert.AreEqual(false, IsPangram("quick brown fox jumps over lazy dog"));
        }

        static bool IsPangram(string text)
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            return alphabet.All(text.ToLower().Contains);
        }
    }
}
