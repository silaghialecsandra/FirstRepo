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

        public double Penalty(double rent, int nrOfDays)
        {
            int[] penaltyProcents = { 2, 5, 10 };
            double[] formula = { (rent + ((penaltyProcents[0] * rent) / 100) * nrOfDays), (rent + (((penaltyProcents[1] * rent) / 100) * (nrOfDays - 10))), (rent + (((penaltyProcents[2] * rent) / 100) * (nrOfDays - 30))) } ;
            if ((nrOfDays >= 1) && (nrOfDays <= 10)) 
                return formula[0] ;
            if ((nrOfDays >= 11) && (nrOfDays <= 30))
                return formula[1];
            if ((nrOfDays >= 31) && (nrOfDays <= 40))
                return formula[2]; 
            return rent;
        }
    }
}
