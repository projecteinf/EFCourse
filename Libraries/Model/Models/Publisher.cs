public class Publisher
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.None)] // No autoincremental
    public int Id { get; set; }
    public string Name { get; set; }
    public string Location { get; set; }
    
}