using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoClassesCRUD
{
    public class Persoon:INotifyPropertyChanged//notify when an event ocurs 
    {
        private string _naam;
        private int _leeftijd;

        public Adres Adres {  get; set; }
        
        public string Naam
        {
            get
            {
                return _naam;
            }
            set
            {
                _naam = value;
                OnPropertyChanged("Naam");//if something change for "naam", the method of the interface is triggered.
            }
        }
               

        public int Leeftijd
        {
            get 
            { 
                return _leeftijd; 
            }
            set 
            { 
                _leeftijd = value;
                OnPropertyChanged("Leeftijd");
            }
        }

        //Implementation of intereface;
        //Delegate:
        public event PropertyChangedEventHandler? PropertyChanged;//Is a delegate from the Interface
        protected void OnPropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}
