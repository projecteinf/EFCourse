using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
public class Publisher
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.None)] // No autoincremental
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Location { get; set; }
    
}