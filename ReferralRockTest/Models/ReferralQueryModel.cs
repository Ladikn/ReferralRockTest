using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReferralRockTest.Models
{
    public class ReferralQueryModel
    {
        public Query query { get; set; }
    }

    public class Query
    {
        public Primaryinfo primaryInfo { get; set; }
    }

    public class Primaryinfo
    {
        public string referralId { get; set; }
    }

}
