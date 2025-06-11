using System.ComponentModel.DataAnnotations;

namespace data_medical_softwere.Modals
{
    public class Division
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;
    }
}