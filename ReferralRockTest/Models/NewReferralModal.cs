using System.ComponentModel.DataAnnotations;

namespace ReferralRockTest.Models
{
    public class NewReferralModal
    {
        [Required]
        public string referralCode { get; set; }
        [Required]
        public string firstName { get; set; }
        [Required]
        public string lastName { get; set; }
        [Required]
        [EmailAddress]
        public string email { get; set; }
    }
}
