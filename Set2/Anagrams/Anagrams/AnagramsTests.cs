/*Anagrame
Pentru un cuvânt dat calculează numărul de anagramări posibile.
Nu trebuie ca cuvintele rezultate să existe în dicționar.
Anagramările nu trebuie să se repete și nu trebuie generate anagramările, doar să se calculeze numărul lor.*/

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Anagrams
{
    [TestClass]
    public class AnagramsTests
    {
        [TestMethod]
        public void Anagrams()
        {
            Assert.AreEqual(0, TotalAnagrams("a"));
            Assert.AreEqual(2, TotalAnagrams("al"));
            Assert.AreEqual(6,TotalAnagrams("ale"));                        
            Assert.AreEqual(20, TotalAnagrams("aaabc"));
        }

        int Factorial(int number)
        {
            return (number <= 1) ? 1 : number * Factorial(number - 1);
        }

        int TotalAnagrams(string word)
        {
            if (word.Length == 1)
                return 0;
            int lettersFactorial = 1;
            int count = 1;
            int totalAnagrams = Factorial(word.Length);
            for (int index = 0; index < word.Length - 1; index++)
            {
                if (word[index] == word[index + 1])
                {
                    count++;
                }
                else
                {
                    lettersFactorial = lettersFactorial * (Factorial(count));
                    count = 1;
                }
            }
            return totalAnagrams / lettersFactorial;
        }
    }
}
