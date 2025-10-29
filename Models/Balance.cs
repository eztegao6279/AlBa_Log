using System.ComponentModel.DataAnnotations;

namespace Models
{
    // Model class representing the Balance entity
    public class Balance
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Product")]
        public string Product { get; set; }

        [Required]
        [Display(Name = "Warehouse")]
        public string Warehouse { get; set; }

        [Required]
        [Range(0, 100000000)]
        [Display(Name = "Amount")]
        public int Amount { get; set; }



    }
}
