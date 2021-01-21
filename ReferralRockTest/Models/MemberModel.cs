namespace ReferralRockTest.Models
{
    public class MemberModel
    {
        public string Id { get; set; }
        public string DisplayName { get; set; }
        public string FirstName { get; set; }
        public int Referrals { get; set; }
        public int ReferralsApproved { get; set; }
        public int ReferralsQualified { get; set; }
        public int ReferralsPending { get; set; }
    }

}
