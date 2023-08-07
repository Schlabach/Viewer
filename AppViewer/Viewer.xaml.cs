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
using System.Windows.Media.Media3D;
using System.Windows.Shapes;

namespace AppViewer
{
    /// <summary>
    /// Interaction logic for Viewer.xaml
    /// </summary>
    public partial class Viewer : Window
    {
        public Viewer(string url)
        {
            InitializeComponent();
            webView.Source = new Uri(url);
            Loaded += Viewer_Loaded;
        }

    private void Viewer_Loaded(object sender, RoutedEventArgs e)
    {
        // Get the screen dimensions
        double screenWidth = SystemParameters.PrimaryScreenWidth;
        double screenHeight = SystemParameters.PrimaryScreenHeight;

        // Set the window position to bottom left corner
        Left = 0;
        Top = screenHeight - Height;
            Topmost = true;
    }
}
}
