/*Un om de știință vrea să știe toate numerele al căror cub se termină cu 888.
Ajută-l prin a-i face un program care pentru numărul k, întoarce al k-lea număr al cărui cub e 888.Exemplu: dacă k e 1, rezultatul e 192*/

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CubicNumber
{
    [TestClass]
    public class CubicNumberTests
    {
        [TestMethod]
        public void CubicNumber()
        {
            Assert.AreEqual(192, Cubic(1));
            Assert.AreEqual(442, Cubic(2));
            Assert.AreEqual(692, Cubic(3));
            Assert.AreEqual(942, Cubic(4));
            Assert.AreEqual(1192, Cubic(5));
        }


        int Cubic(int number)
        {
            int cubic = 0;
            int kNumber = 1;
            for (int index = 192; index < Int32.MaxValue; index++)
            {
                if (((index * index * index) % 1000) == 888)
                    if (number == kNumber)
                    {
                        cubic = index;
                        break;
                    }
                    else
                        kNumber++;
            }
            return cubic;
        }
    }
}
