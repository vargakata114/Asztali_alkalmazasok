using Microsoft.Windows.Themes;
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

namespace Feladat6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Egyszerű lista létrehozása
            var Feladatok = new List<Feladat>
            {
                new Feladat {Nev = "Dokumentáció", Kesz = false},
                new Feladat {Nev = "UI design", Kesz = true},
                new Feladat {Nev = "Backend", Kesz = false}
            };

            // ListBox ItemsSource beállítása - EZ A LEGFONTOSABB!
            lstFeladatok.ItemsSource = Feladatok;
        }
    }

        public class Feladat
        {
            public string Nev { get; set; }
            public bool Kesz { get; set; }
    }
}