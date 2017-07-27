using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Ep7.BibliotecaMasini;

namespace Ep7.MasiniWindows
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //Mașini.Add(new Mașină { Nume = "X", Parcursuri = new ObservableCollection<Parcurs>() { new Parcurs { Timp = 2, Viteză = 50 } } });
            //Mașini.Add(new Mașină { Nume = "Y" });
        }

        public ObservableCollection<Mașină> Mașini { get; set; } = new ObservableCollection<Mașină>();

        private void ButtonAdaugăMașină_Click(object sender, RoutedEventArgs e)
        {
            Mașini.Add(new Mașină { Nume = "Mașina nouă" });
        }

        private void ButtonAdaugăParcurs_Click(object sender, RoutedEventArgs e)
        {
            var element = e.Source as FrameworkElement;
            var mașină = element.DataContext as Mașină;
            mașină.Parcursuri.Add(new Parcurs());
        }
    }
}
