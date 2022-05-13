namespace WebUi.Models
{
    public class Dresseur
    {
        public int DresseurId { get; set; }

        public string Nom { get; set; }

        public string Prénom { get; set; }

        public ICollection<Pokemon> Pokemons { get; set; }

        public Dresseur()
        {
            Pokemons = new List<Pokemon>();
        }
    }
}
