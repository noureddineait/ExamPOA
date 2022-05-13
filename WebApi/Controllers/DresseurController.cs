using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebUi;
namespace WebApi.Controllers
{
    [Route("api/Dresseurs")]
    [Produces("application/json")]
    [ApiController]
    public class DresseurController : ControllerBase
    {
        ExamDbContext examDbContext = new ExamDbContext();
        
        [HttpGet]
        public IActionResult GetDresseur()
        {
            List<WebUi.Models.Dresseur> dresseurs = examDbContext.Dresseurs.ToList();
            return Ok(dresseurs);
        }
        [HttpPost]
        public IActionResult AddDresseur([FromBody] WebUi.Models.Dresseur model)
        {
            try
            {
                WebUi.Models.Dresseur dresseur = new WebUi.Models.Dresseur()
                {
                    Prénom = model.Prénom,
                    Nom = model.Nom
                };
                this.examDbContext.Dresseurs.Add(dresseur);
                this.examDbContext.SaveChanges();
                return Ok(dresseur);
            }
            catch (Exception ex){
                return BadRequest(new { message = "Erreur" });
            }
        }

    }
}
