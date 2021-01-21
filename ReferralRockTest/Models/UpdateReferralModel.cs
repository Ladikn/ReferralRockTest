using System.ComponentModel.DataAnnotations;

namespace ReferralRockTest.Models
{
    public class UpdateReferralContainerModel
    {
        public Query query { get; set; }
        public UpdateReferralModel Referral { get; set; }
    }

    public class UpdateReferralModel
    {
        [Required]
        public string firstName { get; set; }
        [Required]
        public string lastName { get; set; }
        [Required]
        [EmailAddress]
        public string email { get; set; }
    }

}
