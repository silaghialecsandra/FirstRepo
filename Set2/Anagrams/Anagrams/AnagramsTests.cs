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
            Assert.AreEqual(12,TotalAnagrams("ale"));                        
            Assert.AreEqual(288, TotalAnagrams("alex"));
        }

        int Factorial(int number)
        {
            return (number <= 1) ? 1 : number * Factorial(number - 1);
        }

        int TotalAnagrams(string word)
        {
            if (word.Length == 1)
                return 0;
            int totalAnagrams = Factorial(word.Length);            
            for (int index = 2; index < word.Length; index++)
            {
                totalAnagrams = totalAnagrams * Factorial(index);
            }
            return totalAnagrams;
        }
    }
}
