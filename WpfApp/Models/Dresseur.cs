using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp.Models
{
    internal class Dresseur
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
