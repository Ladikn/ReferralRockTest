using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReferralRockTest.Models
{
    public class ReferralsModel
    {
        public int Total { get; set; }
        public string Message { get; set; }
        public ReferralModel[] Referrals { get; set; }
    }

}
