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
            Assert.AreEqual(6, TotalAnagrams("ale"));
            Assert.AreEqual(20, TotalAnagrams("aaabc"));
            Assert.AreEqual(4, TotalAnagrams("aaba"));
        }

        int Factorial(int number)
        {
            return (number <= 1) ? 1 : number * Factorial(number - 1);
        }

        void LettersFromWord(string word, int[] values)
        {
            for (char c = 'a'; c <= 'z'; c++)
            {
                int count = 1;
                for (int index2 = 0; index2 < word.Length; index2++)
                    if (c == word[index2])
                    {
                        values[c - 96] = count;
                        count++;
                    }
            }
        }

        int[] CountLetters(string word)
        {
            int[] values = new int[26];
            LettersFromWord(word, values);
            return values;
        }

        int LettersFactorial(string word, int[] values)
        {
            int lettersFactorial = 1;
            for (int index = 0; index < values.Length; index++)
                if (values[index] != 0)
                    lettersFactorial = lettersFactorial * (Factorial(values[index]));
            return lettersFactorial;
        }

        int TotalAnagrams(string word)
        {
            return (word.Length == 1) ? 0 : AnagramsFormula(word);
        }

        int AnagramsFormula(string word)
        {
            int[] values = new int[26];
            values = CountLetters(word);
            int lettersFactorial = LettersFactorial(word, values);
            int totalAnagrams = Factorial(word.Length);
            return totalAnagrams / lettersFactorial;
        }
    }
}