using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entry
{
    public static class Validator
    {
        public static bool ValidateFullname(string fullname)
        {
            var f = fullname.Split(' ', '.');
            if (f.Length < 3) return false;
            if (f[1].Length > 1 || f[2].Length > 1) return false;
            return true;
        }

        public static bool ValidateDate(DateTime date)
        {
            if (DateTime.Today < date) return false;
            return true;
        }
    }
}
