using System.Media;
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

namespace Proyecto
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Boton_Click(object sender, RoutedEventArgs e)
        {
            Boton.Visibility = Visibility.Collapsed;
            Imagen.Source = new BitmapImage(new Uri("pack://application:,,,/Resources/Max.png"));
            MediaPlayer Sonido = new MediaPlayer();
            Sonido.Open(new Uri("pack://siteoforigin:,,,/Resources/Symphony.mp3"));
            Sonido.Play();
        }
    }
}