/*Un fermier are un teren pătrat. Pentru a-și extinde suprafața a mai cumpărat o parcelă alăturată.
Noua parcelă are acceași lungime și are o lățime de 230m. Acum fermierul are un teren de 77ha (770.000mp).
Ce dimensiune avea inițial terenul?*/

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FarmerLands
{
    [TestClass]
    public class FarmerLandsTests
    {
        [TestMethod]
        public void InitialDimension()
        {
            Assert.AreEqual(4, InitialDimensionFormula(1,8));
        }

        double InitialDimensionFormula(int width, long totalDimension)
        {
            double length;
            length = Math.Pow((totalDimension / width), (1.0 / 3.0));
            return length * length;
        }
    }
}
