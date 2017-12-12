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
            Assert.AreEqual(4, TotalAnagrams("aaba"));
        }

        int Factorial(int number)
        {
            return (number <= 1) ? 1 : number * Factorial(number - 1);
        }

        int TotalAnagrams(string word)
        {
            if (word.Length == 1)
                return 0;
            string allLetters = "abcdefghijklmnopqrstuvwxyz";
            int[] values = new int[26];
            int lettersFactorial = 1;            
            int totalAnagrams = Factorial(word.Length);
            for (int index1 = 0; index1 < allLetters.Length; index1++)
            {
                int count = 1;
                for (int index2 = 0; index2 < word.Length; index2++)
                {
                    if (allLetters[index1] == word[index2])
                    {
                        values[index1] = count;
                        count++;
                    }

                }
            }
            for (int index = 0; index < values.Length; index++)
                if (values[index] != 0)
                    lettersFactorial = lettersFactorial * (Factorial(values[index]));
            return totalAnagrams / lettersFactorial;
        }
    }
}
