using System.ComponentModel.DataAnnotations;

namespace Part1.General
{
    public sealed class InsurancePolicy
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string ProviderName { get; set; }
        [Required]
        public string PolicyNumber { get; set; }
    }
}
