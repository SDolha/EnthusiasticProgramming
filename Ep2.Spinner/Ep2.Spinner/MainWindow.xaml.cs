using System;
using System.Collections.Generic;
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
using System.Windows.Threading;

namespace Ep2.Spinner
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var cronometru = new DispatcherTimer { Interval = TimeSpan.FromMilliseconds(10) };
            cronometru.Tick += Cronometru_Tick;
            cronometru.Start();
        }

        private double viteza = 0.0;
        private const double acceleratie = -0.01;

        private void Cronometru_Tick(object sender, EventArgs e)
        {
            RotatieTriunghi.Angle += 0.05 * viteza;
            viteza = viteza * (1 + acceleratie);
        }

        private void Thumb_DragDelta(object sender, System.Windows.Controls.Primitives.DragDeltaEventArgs e)
        {
            var thumb = sender as FrameworkElement;
            var directie = +1;
            if (thumb.Tag as string == "Invers")
                directie = -1;
            viteza = directie * e.HorizontalChange;
        }
    }
}
