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
            for(int index = 1; index <= dimension; ++index)
                sum += index * index ;
            return sum;
        }
    }
}
