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
        }

         static string Print(int n)
        {
            string multi3 = "Fizz", multi5 = "Buzz", multi35 = "FizzBuzz";        
            if (n % 3 == 0 && n % 5 == 0)
                return multi35;
            if (n % 5 == 0)
                return multi5;            
            if(n % 3 == 0) 
                return multi3;
            else
                return null;
        }
    }
}
