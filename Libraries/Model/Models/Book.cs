using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UdemyCourse.Model.Models;
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
    [ForeignKey("Category")] // Category és el nom de la taula a la que fa referència
    public int CatId { get; set; } // CatId és el nom que volem donar a la clau forana
    public Category Category { get; set; }  // Creació de la relació
}
