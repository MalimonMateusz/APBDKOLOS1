namespace APBD1KOLOS.DTOs;

public class AnimalDTO
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    
    public DateTime AdmissionDate { get; set; }
    public string animalClass { get; set; } = string.Empty;
    
    public OwnerDto Owner { get; set; } = null!;
    
}

public class OwnerDto
{
    public int Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
}