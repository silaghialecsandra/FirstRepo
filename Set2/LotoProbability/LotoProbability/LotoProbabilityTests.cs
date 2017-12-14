/* Loto 6 din 49
 Vrei să participi la jocul de noroc 6 din 49 cu o singură variantă (simplă).
 Calculează ce șanse ai să câștigi la categoria I (6 numere)?
 Calculează ce șanse ai să câștigi la categoria II (5 numere)?
 Calculează ce șanse ai să câștigi la categoria III (4 numere)?
 Calculează și ce șanse ai la categoria I la 5 din 40?*/
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LotoProbability
{
    [TestClass]
    public class LotoProbabilityTests
    {
        [TestMethod]
        public void LotoProbability()
        {
            Assert.AreEqual(0.004f, LotoProbabilityFormula(10, 5, 1));
            Assert.AreEqual(0.099f, LotoProbabilityFormula(10, 5, 2));
            Assert.AreEqual(0.397f, LotoProbabilityFormula(10, 5, 3));
            Assert.AreEqual(0.077f, LotoProbabilityFormula(20, 6, 1));
            Assert.AreEqual(0.31f, LotoProbabilityFormula(20, 6, 2));
            Assert.AreEqual(0.387f, LotoProbabilityFormula(20, 6, 3));

        }

         long Factorial(long number)
        {
            return (number <= 1) ? 1 : number * Factorial(number - 1);
        }

         float AllCombinations(int allNumbers, int chosenNumbers)
        {
            return ((Factorial(allNumbers) / (Factorial(chosenNumbers) * Factorial(allNumbers - chosenNumbers))));
        }

        float CategoryCombinations(int chosenNumbers, int numbersOfCategory)
        {
            return (Factorial(chosenNumbers) / (Factorial(numbersOfCategory - 1) * Factorial(chosenNumbers - (numbersOfCategory - 1))));
        }

        float OtherCombinations(int allNumbers, int chosenNumbers, int numbersOfCategory)
        {
            return (Factorial(allNumbers - chosenNumbers) / (Factorial(chosenNumbers - (numbersOfCategory - 1)) * Factorial((allNumbers - chosenNumbers) - (chosenNumbers - (numbersOfCategory - 1)))));
        }

        float LotoProbabilityFormula(int allNumbers, int chosenNumbers, int numbersOfCategory)
        {
            float probability = (CategoryCombinations(chosenNumbers, numbersOfCategory) * OtherCombinations(allNumbers, chosenNumbers, numbersOfCategory)) / AllCombinations(allNumbers, chosenNumbers);
            return (float)(Math.Round((double)(probability), 3));
        }
    }
}
