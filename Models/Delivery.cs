using System.ComponentModel.DataAnnotations;

namespace PäronTEST.Models
{
    // Model class representing the Delivery entity
    public class Delivery
    {
        public int Id { get; set; }

        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        public DateTime? Date { get; set; }

        [Required]
        [Display(Name = "Product")]
        public string Product { get; set; }

        [Required]
        [Display(Name = "To/From Warehouse")]
        public string Warehouse { get; set; }

        [Required]
        [Range(-100000000, 100000000)]
        [Display(Name = "Amount")]
        public int Amount { get; set; }

        [StringLength(5000, MinimumLength = 3)]
        [Display(Name = "Note")]
        public string? Note { get; set; }



    }
}
