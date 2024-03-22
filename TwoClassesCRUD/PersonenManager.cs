using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TwoClassesCRUD
{
    public class PersonenManager: INotifyPropertyChanged
    {
        //Collection to simulate a DB (Personen IS THE DB)
        public ObservableCollection<Persoon> Personen { get; private set; }// private set:Can read it but not write it

        public PersonenManager()
        {
            Personen = new ObservableCollection<Persoon>();
            SeedData();
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void SeedData()
        {
            Personen.Add(new Persoon { Naam = "Rik", Leeftijd = 30, Adres = new Adres { Straat = "Rue1", Stad = "Antwerpen" } });
            Personen.Add(new Persoon { Naam = "Zak", Leeftijd = 25, Adres = new Adres { Straat = "Straat2", Stad = "Brussel" } });
            Personen.Add(new Persoon { Naam = "Gab", Leeftijd = 27, Adres = new Adres { Straat = "Ster", Stad = "kortijk" } });
            Personen.Add(new Persoon { Naam = "Hug", Leeftijd = 26, Adres = new Adres { Straat = "Chip", Stad = "Brussel" } });
        }
        
    }

    
}
