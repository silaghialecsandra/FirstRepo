/*Ai de plătit chiria lunară.Dar cu fiecare zi de întârziere trebuie să plătești o penalitate.
Dacă ai întârziat:
1-10 zile - plătești o penalitate de 2% din chirie/zi întârzire
11-30 zile - plătești o penalitate de 5% din chirie/zi întârzire
31-40 zile - plătești o penalitate de 10% din chirie/zi întârzire
Dacă ști chiria și numărul de zile de întârziere, calculează suma totală de plată.*/

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MoneyDebts
{
    [TestClass]
    public class MoneyDebtsTests
    {
        [TestMethod]
        public void TotalPayment()
        {
            Assert.AreEqual(1020, Penalty(1000, 1));
            Assert.AreEqual(836.4, Penalty(820, 1));
            Assert.AreEqual(1050, Penalty(1000, 11));
            Assert.AreEqual(1100, Penalty(1000, 31));
        }

        public double Penalty(double Rent, int NrOfDays)
        {
            if ((NrOfDays >= 1) && (NrOfDays <= 10))
                return Rent + (((2 * Rent) / 100) * NrOfDays);
            if ((NrOfDays >= 11) && (NrOfDays <= 30))
                return Rent + (((5 * Rent) / 100) * (NrOfDays - 10));
            if ((NrOfDays >= 31) && (NrOfDays <= 40))
                return Rent + (((10 * Rent) / 100) * (NrOfDays - 30));
            return 0;
        }
    }
}
