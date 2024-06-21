using APBD1KOLOS.DTOs;
using APBD1KOLOS.Repo;
using Microsoft.AspNetCore.Mvc;

namespace APBD1KOLOS.Controllers;
[Route("api/[controller]")]
[ApiController]

public class animalsController : ControllerBase
{
    private readonly IFAnimalRepo _animalsRepository;
    public animalsController(IFAnimalRepo animalsRepository)
    {
        _animalsRepository = animalsRepository;
    }
    
    
    [HttpGet("{id}")]
    public async Task<IActionResult> GetAnimal(int id)
    {
        if (!await _animalsRepository.DoesAnimalExist(id))
            return NotFound($"Animal with given ID - {id} doesn't exist");

        var animal = await _animalsRepository.GetAnimal(id);
            
        return Ok(animal);
    }
    
    
    
    
    [HttpPost]
    public async Task<IActionResult> AddAnimal(AddAnimalDTO addAnimalDTO)
    {
        if (!await _animalsRepository.DoesOwnerExist(addAnimalDTO.ownerID))
            return NotFound($"Owner with given ID - {addAnimalDTO.ownerID} doesn't exist");

        foreach (var procedure in addAnimalDTO.Procedures)
        {
            if (!await _animalsRepository.DoesProcedureExist(procedure.ProcedureId))
                return NotFound($"Procedure with given ID - {procedure.ProcedureId} doesn't exist");
        }

        await _animalsRepository.AddNewAnimalWithProcedures(addAnimalDTO);

        return Created(Request.Path.Value ?? "api/animals", addAnimalDTO);
    }
    
    
}