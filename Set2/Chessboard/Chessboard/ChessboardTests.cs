/*Calculează câte pătrate se pot forma pe o tablă de șah de dimensiunea de 8 x 8.*/

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Chessboard
{
    [TestClass]
    public class ChessboardTests
    {
        [TestMethod]
        public void ChessboardSquares()
        {
            Assert.AreEqual(204, SquaresFormula(8));
        }

        int SquaresFormula( int dimension)
        {
            int sum = 0;
            while (dimension >= 1)
            {
                sum = sum + ((dimension * dimension) + ((dimension - 1) * (dimension - 1)));
                dimension = dimension - 2;
            }
            return sum;
        }
    }
}
