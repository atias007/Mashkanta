using System;

namespace Mashkanta
{
    public static class Utils
    {
        public static double Pmt(double rate, int NPER, double PV, long FV = 0, int TYPE = 0)
        {
            return -rate * (FV + PV * Math.Pow(1 + rate, NPER)) / ((Math.Pow(1 + rate, NPER) - 1) * (1 + rate * TYPE));
        }

        public static double Round2(double value)
        {
            return Math.Round(value, 2);
        }

        public static double Round4(double value)
        {
            return Math.Round(value, 4);
        }
    }
}