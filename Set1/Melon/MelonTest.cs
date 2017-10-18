using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Melon
{
    [TestClass]
    public class MelonTest
    {
        [TestMethod]
        public void Division()
        {
            Assert.AreEqual(true, Quantity(8, 4, 4));
            Assert.AreEqual(true, Quantity(6, 4, 2));
        }

        bool Quantity(int kg, int part1, int part2)
        {
            if (kg == part1 + part2)         
                return part1 % 2 == 0 && part2 % 2 == 0; 
            return false;               

        }
    }
}
