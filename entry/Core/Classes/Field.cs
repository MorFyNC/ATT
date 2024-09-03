using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entry
{
    public class Field
    {
        public string Fullname { get; private set; }
        public double Comission { get; private set; }
        public double DailyEarnings { get; private set; }
        public int Experience { get; private set; }
        public Field(Seller seller, double dailyEarnings)
        {
            Fullname = seller.Fullname;
            DailyEarnings = dailyEarnings;
            Comission = ComissionCalculator.Calculate(seller, dailyEarnings);
            Experience = DateTime.Today.Year - seller.AppliedToJob.Year;
        }
    }
}
