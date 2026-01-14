using System.ComponentModel.DataAnnotations;

namespace RazorPageWatches.Models
{
    public class Watch
    {
        public int Id { get; set; }
        public string? Model { get; set; }
        public string? Brand { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        public decimal Price { get; set; }
    }
}
