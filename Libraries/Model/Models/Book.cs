using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
public class Book
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string Title { get; set; }
    [Required]
    [MaxLength(15)]
    public string ISBN { get; set; }
    [Required]
    public double price { get; set; }
    [NotMapped] // Atribut de visualització
    public string PriceRange { get; set; }
}
