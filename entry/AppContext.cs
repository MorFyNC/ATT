using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entry
{
    public static class AppContext
    {
        public static List<Seller> Sellers { get; private set; } = new List<Seller>();
        public static void AddSeller(Seller seller) => Sellers.Add(seller);
        public static Seller SelectedSeller { get; set; }
        public static List<Field> PayList { get; set; } = new List<Field>();
    }
}
