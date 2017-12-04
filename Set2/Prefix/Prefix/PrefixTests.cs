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
        }

        public char[] Prefix(string firstString, string secondString)
        {
            char[] prefix = new char[10];
            for (int i = 0; i < firstString.Length; i++)
            {
                if (firstString[i] == secondString[i])
                    prefix[i] = firstString[i];
                else
                    break;
            }
            return prefix;
        }
    }
}
