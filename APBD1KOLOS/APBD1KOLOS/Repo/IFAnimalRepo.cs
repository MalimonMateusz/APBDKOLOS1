using APBD1KOLOS.DTOs;

namespace APBD1KOLOS.Repo;

public interface IFAnimalRepo
{
    Task<bool> DoesAnimalExist(int id);
    Task<AnimalDTO> GetAnimal(int id);
    
    Task<bool> DoesAnimalClassExist(int id);
    Task<bool> DoesOwnerExist(int id);
    Task<bool> DoesProcedureExist(int id);
    
    Task AddNewAnimalWithProcedures(AddAnimalDTO addAnimalDTO);
    
    
}