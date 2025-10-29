using System.ComponentModel.DataAnnotations;
namespace Models
{
    public class Warehouse
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Range(1,10000)]
        [Display(Name = "Warehouse Number")]
        public int WarehouseNumber { get; set; }


        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string City { get; set; }
    }
}