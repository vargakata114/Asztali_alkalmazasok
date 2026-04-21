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

namespace SzemelyesAdatlapUrlap
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool enabled {  get; set; }
        string name { get; set; }
        int nemek {  get; set; }
        DateTime datum { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            enabled = false;
            name = string.Empty;
            nemek = 0;
            datum = DateTime.Now;
        }
    }
}