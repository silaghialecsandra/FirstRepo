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
            double formula = (rent + ((penaltyProcents * rent) / 100) * penaltyDays) ;
            return formula;
        }

        public double PenaltyInterval(double rent, int nrDaysLate)
        {
            if ((nrDaysLate >= 1) && (nrDaysLate <= 10))
                return PenaltyFormula(rent, 2, nrDaysLate);
            if ((nrDaysLate >= 11) && (nrDaysLate <= 30))
                return PenaltyFormula(rent, 5, nrDaysLate - 10);
            if ((nrDaysLate >= 31) && (nrDaysLate <= 40))
                return PenaltyFormula(rent, 10, nrDaysLate - 30);
            return rent;
        }

        public double Penalty(double rent, int nrDaysLate)
        {
            return PenaltyInterval(rent, nrDaysLate);
        }
    }
}
