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

namespace BindingsWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Person person = new Person();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            person.Naam = txtNaam.Text;//Data Binding:txtnaam is "source", and person.naam is "destination"
            person.leeftijd = int.Parse(txtLeeftijd.Text);

            MessageBox.Show(person.Naam + " " + person.leeftijd);
        }
    }
}