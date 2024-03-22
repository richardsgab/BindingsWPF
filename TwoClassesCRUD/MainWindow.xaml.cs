using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TwoClassesCRUD
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public PersonenManager PersonenManager { get; set; }
        PersonenManager manager = new PersonenManager();

        Persoon persoon = new Persoon();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = manager;//it's a intermediate layer between Frontend & backend.It's a context;zoals http is also
         
        }     
        

        private void AddData_Click(object sender, RoutedEventArgs e)
        {           
           
            var newpers = new Persoon { Naam = tboxInputname.Text, Leeftijd = int.Parse(txtLeefTInput.Text), Adres = new Adres { Straat = "Rue1", Stad = "Antwerpen" } };
            manager.Personen.Add(newpers);
            MessageBox.Show("WTF???");
        }
    }
}