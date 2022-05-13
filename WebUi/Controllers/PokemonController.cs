using Microsoft.AspNetCore.Mvc;

namespace WebUi.Controllers
{
    public class PokemonController : Controller
    {
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Models.Pokemon pokemon)
        {
            if (ModelState.IsValid)
            {
                ExamDbContext examDbContext = new ExamDbContext();
                examDbContext.Pokemons.Add(pokemon);
                examDbContext.SaveChanges();
                return RedirectToAction("Add");
            }
            return View(pokemon);
        }
    }
}
