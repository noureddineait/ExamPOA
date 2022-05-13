
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WpfApp.ViewModels;
namespace WpfApp.ViewModels
{
    internal class MainViewModel
    {
        public Models.Dresseur Dresseur { get; set; }
        public ObservableCollection<Models.Dresseur> Dresseurs { get; set; }
        public ObservableCollection<Models.Pokemon> Pokemons { get; set; }

        public ICommand AjoutCommand { get; set; }
        public ICommand AfficherCommand { get; set; }
        public ICommand AssocierCommand { get; set; }
        public MainViewModel()
        {
            Dresseur = new Models.Dresseur();
            Dresseurs = new ObservableCollection<Models.Dresseur>();
            Pokemons = new ObservableCollection<Models.Pokemon>();

            AjoutCommand = new RelayCommand(
                o => true,
                o => Ajouter());
            AfficherCommand= new RelayCommand(
                o => true,
                o => Afficher());

            AssocierCommand= new RelayCommand(
                o => true,
                o => Associer());
        }

        public void Ajouter()
        {
            RestApiQueries restApiQueries = new RestApiQueries();
            bool test = restApiQueries.AddDresseur(Dresseur, "Dresseurs");
            if (test)
            {

            }
            else
            {
                MessageBox.Show("Une Erreur est survenue !");
            }
        }
    }
}
