using System.ComponentModel.DataAnnotations;

namespace WebUi.Models
{
    public class Pokemon
    {
        public int PokemonId { get; set; }

        [Required(ErrorMessage ="Champs Requis !")]
        public string? Nom { get; set; }
        [Required(ErrorMessage = "Champs Requis !")]
        public int Niveau { get; set; }
        //[Required(ErrorMessage = "Champs Requis !")]       
        public string? Type { get; set; }
        
        public int? DresseurID { get; set; }
        public Dresseur? Dresseur { get; set; }
    }
}
