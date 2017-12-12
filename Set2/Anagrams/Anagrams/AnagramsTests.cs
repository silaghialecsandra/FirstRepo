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
            Assert.AreEqual(0, TotalAnagramsFormula("a"));
            Assert.AreEqual(2, TotalAnagramsFormula("al"));
            Assert.AreEqual(6,TotalAnagramsFormula("ale"));                        
            Assert.AreEqual(20, TotalAnagramsFormula("aaabc"));
            Assert.AreEqual(4, TotalAnagramsFormula("aaba"));
        }

        int Factorial(int number)
        {
            return (number <= 1) ? 1 : number * Factorial(number - 1);
        }

        static int[] CountLetters(string word)
        {
            int[] values = new int[26];
            for (int index1 = 0; index1 < 26; index1++)
            {
                int count = 1;
                for (int index2 = 0; index2 < word.Length; index2++)
                    if ((char)('a' + index1) == word[index2])
                    {
                        values[index1] = count;
                        count++;
                    }
            }
            return values;
        }

        int TotalAnagramsFormula(string word)
        {
            int[] values ;
            values = CountLetters(word);
            if (word.Length == 1)
                return 0;
            int lettersFactorial = 1;
            int totalAnagrams = Factorial(word.Length);
            for (int index = 0; index < values.Length; index++)
                if (values[index] != 0)
                    lettersFactorial = lettersFactorial * (Factorial(values[index]));
            return totalAnagrams / lettersFactorial;
        }
    }
}
