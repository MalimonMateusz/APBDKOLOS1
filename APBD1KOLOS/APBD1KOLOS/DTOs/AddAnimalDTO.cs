namespace APBD1KOLOS.DTOs;

public class AddAnimalDTO
{
    public string Name { get; set; } = string.Empty;
    public string animalClass { get; set; } = string.Empty;
    public DateTime AdmissionDate { get; set; }
    public int ownerID { get; set; }
    
    
    public IEnumerable<ProcedureWithDate> Procedures { get; set; } = new List<ProcedureWithDate>();
}

public class ProcedureWithDate
{
    public int ProcedureId { get; set; }
    public DateTime Date { get; set; }
}