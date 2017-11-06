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


        public double PenaltyFormula(double rent, int nrOfDays, int penaltyProcents, int days)
        {                       
            double formula = (rent + ((penaltyProcents * rent) / 100) * (nrOfDays - days)) ;
            return formula;
        }

         public double Penalty(double rent, int nrOfDays)
        {
            if ((nrOfDays >= 1) && (nrOfDays <= 10))
                return PenaltyFormula(rent, nrOfDays, 2, 0);
            if ((nrOfDays >= 11) && (nrOfDays <= 30))
                return PenaltyFormula(rent, nrOfDays, 5, 10);
            if ((nrOfDays >= 31) && (nrOfDays <= 40))
                return PenaltyFormula(rent, nrOfDays, 10, 30);
            return rent;
        }
    }
}
