using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
public class Author
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; }
    public string Location { get; set; }
    [NotMapped]
    public string FullName { 
        get { 
            return $"{FirstName} {LastName}"; 
        }
    }
    
}