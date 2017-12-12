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
            Assert.AreEqual(0, AllAnagrams("a"));
            Assert.AreEqual(2, AllAnagrams("al"));
            Assert.AreEqual(6, AllAnagrams("ale"));
            Assert.AreEqual(20, AllAnagrams("aaabc"));
            Assert.AreEqual(4, AllAnagrams("aaba"));
        }

        int Factorial(int number)
        {
            return (number <= 1) ? 1 : number * Factorial(number - 1);
        }


        int CountChar(string word, char c)
        {
            int count = 0;
            for (int index = 0; index < word.Length; index++)
                if (c == word[index])
                    count++;
            return count;
        }

        int[] LettersFromWord(string word)
        {
            int[] values = new int[26];
            for (char c = 'a'; c < 'z'; c++)
                values[c - 96] = CountChar(word, c);
            return values;
        }

        int FactorialsProduct(int[] values)
        {
            int lettersFactorial = 1;
            for (int index = 0; index < values.Length; index++)
                if (values[index] != 0)
                    lettersFactorial = lettersFactorial * (Factorial(values[index]));
            return lettersFactorial;
        }

        int AllAnagrams(string word)
        {
            int[] values = LettersFromWord(word);
            return (word.Length == 1) ? 0 : (Factorial(word.Length) / FactorialsProduct(values));
        }
    }
}