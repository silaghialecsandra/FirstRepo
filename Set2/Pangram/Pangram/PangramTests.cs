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
            bool[] existingLetters = new bool[26];
            int totalLetters = 0;
            text = text.ToLower();
            if (text.Length < 26)
                return false;
            foreach (char c in text)
            {
                if (c >= 'a' && c <= 'z')
                {
                    int index = c - 'a';
                    if (!existingLetters[index])
                    {
                        existingLetters[index] = true;
                        totalLetters++;
                    }
                }
            }
            return totalLetters == 26;
        }
    }
}
