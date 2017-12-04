/*Tu și prietenul tău vă întâlniți întâmplător la restaurant.
În timpul mesei de prânz din discuția avută cu el, afli că el ia prânzul la acel restaurant din 4 în 4 zile.
Când te vei întâlni din nou cu el, dacă tu iei prânzul la restaurantul respectiv odată la 6 zile? */

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lunch
{
    [TestClass]
    public class LunchTests
    {
        [TestMethod]
        public void Lunch()
        {
        }

        char LunchDays()
        {
            string daysOfWeek = " Monday Tuesday Wednesday Thursday Friday Saturday Sunday";
            for(int i=1;i <= daysOfWeek.Length;i++)
                for (int j = 1; j <= daysOfWeek.Length; j++)
                {
                    if ((4 * i) == (6 * j))
                        return daysOfWeek[i];
                }
            return 'a';
        }
    }
}
