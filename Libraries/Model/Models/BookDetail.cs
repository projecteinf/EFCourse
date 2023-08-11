using System.ComponentModel.DataAnnotations;

namespace UdemyCourse.Model.Models
{
    public class BookDetail
    {
        [Key]
        public int Id { get; set; }
        public int NumberOfChapters { get; set; }
        public int NumberOfPages { get; set; }
        [Required]
        public string Language { get; set; }
        public double Weight { get; set; }
        public Book Book { get; set; }
    }
}