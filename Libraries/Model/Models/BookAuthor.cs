using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UdemyCourse.Model.Models;
public class BookAuthor
{
    public int BookId { get; set; }
    public int AuthorId { get; set; }
    public Book Book { get; set; }
    public Author Author { get; set; }
}
