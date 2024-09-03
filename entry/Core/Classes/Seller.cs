using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entry
{
    public class Seller
    {
        public Guid ID { get; set; }
        public string Fullname { get; set; }
        public DateTime AppliedToJob { get; set; }

        public Seller(string fullname, DateTime appliedToJob)
        {
            Fullname = fullname;
            AppliedToJob = appliedToJob;
            ID = Guid.NewGuid();
        }
    }
}
