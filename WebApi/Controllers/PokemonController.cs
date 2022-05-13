using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebUi;

namespace WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/Pokemons")]
    [ApiController]
    public class PokemonController : ControllerBase
    {
        ExamDbContext examDbContext;
        public PokemonController()
        {
            examDbContext = new ExamDbContext();
        }
        [HttpGet(Name = "GetPokemons")]
        public IActionResult GetPokemons()
        {
            List<WebUi.Models.Pokemon> pokemons = this.examDbContext.Pokemons.ToList();
            return Ok(pokemons);
        }
    }
}
