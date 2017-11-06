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
            Assert.AreEqual(800, Penalty(800, 0));
            Assert.AreEqual(1020, Penalty(1000, 1));
            Assert.AreEqual(836.4, Penalty(820, 1));          
            Assert.AreEqual(1100, Penalty(1000, 31));
            Assert.AreEqual(1800, Penalty(1500, 32));
        }


        public double PenaltyFormula(double rent, int penaltyProcents, int penaltyDays)
        {
            double formula = (rent + ((penaltyProcents * rent) / 100) * penaltyDays);
            return formula;
        }

        bool IsInInterval(int number, int start, int end)
        {
           return (number >= start) && (number <= end) ;
        }

        public double Penalty(double rent, int daysLate)
        {
            if (IsInInterval(daysLate, 1, 10))
                return PenaltyFormula(rent, 2, daysLate);
            if (IsInInterval(daysLate, 11, 30))
                return PenaltyFormula(rent, 5, daysLate - 10);
            if (IsInInterval(daysLate, 31, 40))
                return PenaltyFormula(rent, 10, daysLate - 30);
            return rent;
        }
    }
}
