using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace data_medical_softwere.Modals
{
    public class Vendor
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Display(Name = "NTN Number")]
        public string NtnNumber { get; set; } = string.Empty;

        public string Address { get; set; } = string.Empty;

        [Phone]
        public string Phone { get; set; } = string.Empty;

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        // Foreign Key
        [Required]
        [Display(Name = "Division")]
        public int DivisionId { get; set; }

        [ForeignKey("DivisionId")]
        public Division? Division { get; set; }

        public ICollection<Group> Groups { get; set; } = new List<Group>();
    }
}