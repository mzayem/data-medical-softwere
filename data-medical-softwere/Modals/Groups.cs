using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace data_medical_softwere.Modals
{
    public class Group
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        // Foreign key to Vendor
        [Required]
        [Display(Name = "Vendor")]
        public int VendorId { get; set; }

        [ForeignKey("VendorId")]
        public Vendor? Vendor { get; set; }
    }
}