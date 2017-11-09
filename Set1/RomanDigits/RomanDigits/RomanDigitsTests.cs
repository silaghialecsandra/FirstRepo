/*Cifre romane: Convertește un număr dat, între 1 și 100, în cifre romane.
I - 1   V - 5  X - 10  L - 50  C - 100 */


using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RomanDigits
{
    [TestClass]
    public class RomanDigitsTests
    {
        [TestMethod]
        public void ConversionTest()
        {
            /*Assert.AreEqual("LI", ConvertNumberToRoman(51));
            Assert.AreEqual("XIX", ConvertNumberToRoman(19));
            Assert.AreEqual("C", ConvertNumberToRoman(100));
            Assert.AreEqual("XCIX", ConvertNumberToRoman(99));
            Assert.AreEqual("XXVIII", ConvertNumberToRoman(28));
            Assert.AreEqual("LXXXIX", ConvertNumberToRoman(89));*/
        }

        string ConvertNumberToRoman(int number)
        {
            string[] I = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
            string[] X = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            string[] C = { "", "C" };
            return C[(number % 1000) / 100] + X[(number % 100) / 10] + I[(number % 10)];
        }
    }
}
