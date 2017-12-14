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
            Assert.AreEqual(0.436, LotoProbabilityFormula(49,6,1));
            Assert.AreEqual(0.413, LotoProbabilityFormula(49,6,2));
            Assert.AreEqual(0.132, LotoProbabilityFormula(49,6,3));
            Assert.AreEqual(0.493, LotoProbabilityFormula(40,5,1));
        }

        double Factorial(int number)
        {
            return (number <= 1) ? 1 : number * Factorial(number - 1);
        }

        double AllCombinations(int allNumbers, int chosenNumbers)
        {
            return ((Factorial(allNumbers) / (Factorial(chosenNumbers) * Factorial(allNumbers - chosenNumbers))));
        }

        double CategoryCombinations(int chosenNumbers, int numbersOfCategory)
        {
            return (Factorial(chosenNumbers) / (Factorial(numbersOfCategory - 1) * Factorial(chosenNumbers - (numbersOfCategory - 1))));
        }

        double OtherCombinations(int allNumbers, int chosenNumbers, int numbersOfCategory)
        {
            return (Factorial(allNumbers - chosenNumbers) / (Factorial(chosenNumbers - (numbersOfCategory - 1)) * Factorial((allNumbers - chosenNumbers) - (chosenNumbers - (numbersOfCategory - 1)))));
        }

        double LotoProbabilityFormula(int allNumbers, int chosenNumbers, int numbersOfCategory)
        {
            double probability = (CategoryCombinations(chosenNumbers, numbersOfCategory) * OtherCombinations(allNumbers, chosenNumbers, numbersOfCategory)) / AllCombinations(allNumbers, chosenNumbers);
            return (double)(Math.Round((double)(probability), 3));
        }
    }
}
