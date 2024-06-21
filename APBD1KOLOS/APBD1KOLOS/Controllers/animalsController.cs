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
    
}