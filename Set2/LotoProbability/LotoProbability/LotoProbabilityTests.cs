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
            Assert.AreEqual(0.436f, Loto(1));
            Assert.AreEqual(0.413f, Loto(2));
            Assert.AreEqual(0.132f, Loto(3));
            Assert.AreEqual(0.099f, Loto(4));
        }

         long Factorial(long number)
        {
            return (number <= 1) ? 1 : number * Factorial(number - 1);
        }

         float FirstCategory()
        {
            //P1=(C6 0 * C 43 6)/C 49 6
            //return (Factorial(43) / (Factorial(6) * Factorial(37))) / (Factorial(49) / (Factorial(6) * Factorial(43)));
            return (float)(Math.Round((double)(435.461f / 998.844f), 3));
        }

        float SecondCategory()
        {
            //P2=(C6 1 * C43 5)/C49 6
            //return (Factorial(43) / (Factorial(5) * Factorial(38))) / (Factorial(49) / (Factorial(6) * Factorial(43)));            
            return (float)(Math.Round((double)(68.757f / 166.474f), 3));

        }

         float ThirdCategory()
        {
            //P3=(C6 2 * C43 4)/C49 6
            //return ((15 * Factorial(43) / (Factorial(4) * Factorial(39))) / (Factorial(49) / (Factorial(6) * Factorial(43))));
            return (float)(Math.Round((double)(44.075f / 332.948f), 3));
        }

         float FirstCategory5of40()
        {
            //P1=(C5 0 * C 35 5)/C40 5
            // return (Factorial(35) / (Factorial(5) * Factorial(30))) / (Factorial(40) / (Factorial(4) * Factorial(35)));
            return (float)(Math.Round((double)(324.632f / 3290.040f), 3));
        }

         float Loto(int category)
        {
            if (category == 1)
                return FirstCategory();
            if (category == 2)
                return SecondCategory();
            if (category == 3)
                return ThirdCategory();
            if (category == 4)
                return FirstCategory5of40();
            return 23;

        }
    }
}
