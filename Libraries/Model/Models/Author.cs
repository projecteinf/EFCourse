using System.ComponentModel.DataAnnotations.Schema;
public class Author
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public dateTime BirthDate { get; set; }
    public string Location { get; set; }
    [notMapped]
    public string FullName { 
        get { 
            return $"{FirstName} {LastName}"; 
        }
    }
    
}