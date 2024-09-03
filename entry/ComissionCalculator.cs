using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entry
{
    public static class ComissionCalculator
    {

        public static double Calculate(Seller seller, double dailyEarnings)
        {
            double res = dailyEarnings * GetPercent(seller, dailyEarnings);

            return res;
        }

        private static double GetPercent(Seller seller, double dailyEarnings)
        {
            double percentage = 0;
            if (dailyEarnings < 50000) percentage = 0.03;
            else percentage = 0.06;
            if (DateTime.Today.Year - seller.AppliedToJob.Year > 3) percentage += 0.05;
            return percentage;
        }
    }
}
