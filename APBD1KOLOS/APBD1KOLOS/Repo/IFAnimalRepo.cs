using APBD1KOLOS.DTOs;

namespace APBD1KOLOS.Repo;

public interface IFAnimalRepo
{
    Task<bool> DoesAnimalExist(int id);
    Task<AnimalDTO> GetAnimal(int id);
}