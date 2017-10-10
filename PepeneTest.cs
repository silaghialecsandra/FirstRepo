using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Pepene
{
    [TestClass]
    public class PepeneTest
    {
        [TestMethod]
        public void Impartire()
        {
            Assert.AreEqual(true,Cantitate(8,4,4));
            Assert.AreEqual(true, Cantitate(6, 4, 2));
        }

        bool Cantitate(int x,int p1,int p2)
        {
            if (x==p1+p2)
            {
                if (p1 % 2 == 0 && p2 % 2 == 0)
                    return true;
            }
            return false;                  
        }
    }
}
