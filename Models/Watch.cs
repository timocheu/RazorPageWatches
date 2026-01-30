using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPageWatches.Models
{
    public class Watch
    {
        public int Id { get; set; }

        [StringLength(50, MinimumLength = 2)]
        [Required]
        public string? Model { get; set; }

        [StringLength(50, MinimumLength = 2)]
        [Required]
        public string? Brand { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [Range(minimum: 0, maximum: 10e12, ErrorMessage = "It must be a positive value")]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        [Range(minimum: 1, maximum: 5)]
        [Column(TypeName = "decimal(5, 2)")]
        public decimal Rating { get; set; }
    }
}
