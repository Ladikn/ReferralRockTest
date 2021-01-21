using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReferralRockTest.Models
{
    public class MembersModel
    {
        public int Offset { get; set; }
        public int Total { get; set; }
        public object Message { get; set; }
        public MemberModel[] Members { get; set; }
    }
}
