using Aplicacion;
using Microsoft.AspNetCore.Mvc;
using Repositorio;

namespace Presentacion;

[ApiController]
[Route("api/challenges")]
public class Controlador : ControllerBase
{
    private readonly ChallengeService _service;

    // Inyección del ChallengeService
    public Controlador(ChallengeService service)
    {
        _service = service;
    }

    [HttpPost("create")]
    public ActionResult Create(ChallengeCreateDto challengeDto)
    {
        int dificultad = challengeDto.difficulty;
        
        if (challengeDto.Title.Equals(""))
        {
            return BadRequest("El reto debe tener título");
        }else if(challengeDto.difficulty.Equals("")){
            return BadRequest("El reto debe tener una dificultad");
        }else if(dificultad < 1 || dificultad > 5)
        {
            return BadRequest("La dificulta debe ser entre 1 y 5");
        }

        var challenge = new Challenge
        {
            Title = challengeDto.Title,
            Description = challengeDto.Description,
            Difficulty = (DifficultyLevel)challengeDto.difficulty
        };
    
        _service.CreateChallenge(challenge);
        return Ok();
    }

    [HttpGet("{id:int}")]
    public ActionResult<Challenge> GetById(int id)
    {
        var challenge = _service.GetById(id);
        return challenge is null ? NotFound(): Ok(challenge);

    }

    [HttpGet]
    public ActionResult<List<Challenge>> GetAll()
    {
        return Ok(_service.GetAll());
    }

    [HttpPost("delete/{id:int}")]
    public ActionResult Delete(int id)
    {
        _service.DeleteChallenge(id);
        return Ok();

    }
}