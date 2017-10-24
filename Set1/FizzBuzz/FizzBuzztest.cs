/*Pentru un numar dat daca e multiplu de 3 rezultatul trebuie sa fie Fizz iar daca e multiplu de 5 
 * rezultatul trebuie sa fie Buzz.Daca e multiplu de 3 si de 5 rezultatul trebuie sa fie FizzBuzz.*/
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz
{
    [TestClass]
    public class FizzBuzztest
    {
        [TestMethod]
        public void FizzBuzz()
        {
            Assert.AreEqual("FizzBuzz", Print(45));
            Assert.AreEqual("Buzz", Print(10));
            Assert.AreEqual("Fizz", Print(9));
            Assert.AreEqual(null, Print(13));
        }

         static string Print(int n)
        {
            string fizz = "Fizz";
            string buzz = "Buzz";        
            if (n % 3 == 0 && n % 5 == 0)
                return fizz+buzz;
            if (n % 5 == 0)
                return buzz;            
            if(n % 3 == 0) 
                return fizz;
            else
                return null;
        }
    }
}
