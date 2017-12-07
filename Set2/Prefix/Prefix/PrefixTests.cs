/*Dacă ai două stringuri, găsește-le prefixul comun. Exemplu: "aaab" și "aaaabbaa" au prefixul comun "aaa" */

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Prefix
{
    [TestClass]
    public class PrefixTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("aaa",Prefix("aaab", "aaaabbaa"));
            Assert.AreEqual("", Prefix("baaab", "aaaabbaa"));
            Assert.AreEqual("abcd", Prefix("abcd", "abcddaa"));
            Assert.AreEqual("d", Prefix("dvaaab", "daaaabbaa"));
        }

        static string Prefix(string firstString, string secondString)
        {
            int count = 0;
            for (int i = 0; i < firstString.Length; i++)
            {
                if (firstString[i] == secondString[i])
                    count++;
                else
                    break;
            }
            return firstString.Substring(0, count);
        }
    }
}
