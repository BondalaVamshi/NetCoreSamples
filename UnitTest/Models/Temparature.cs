using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnitTest.Models
{
    public static class Temparature
    {
        public static double CelciousToFahreinheit(double Tc)
        {
            double Tf;
            Tf = 9 / 5 * Tc + 32;
            return Tf;
        }
    }
}
