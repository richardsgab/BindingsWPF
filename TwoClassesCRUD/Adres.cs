using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoClassesCRUD
{
    public class Adres:INotifyPropertyChanged
    {
		private string _straat;
		private string _stad;

		public string Straat
		{
			get {
				return _straat; 
			}
			set 
			{
				_straat = value;
				OnPropertyChanged("straat");
			}
		}


        public string Stad
		{
			get 
			{ 
				return _stad; 
			}
			set 
			{ 
				_stad = value;
                OnPropertyChanged(nameof(Stad));
            }
		}

        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged(string v)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(v));
        }
    }
}
