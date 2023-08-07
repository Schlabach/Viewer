using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Security.Policy;
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

namespace AppViewer
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void YouTube_Click(object sender, RoutedEventArgs e)
        {
            Viewer youTubeTV = new Viewer("http://tv.youtube.com/");
            youTubeTV.Show();
        }

        private void Netflix_Click(object sender, RoutedEventArgs e)
        {
            Viewer netflix = new Viewer("http://www.netflix.com/");
            netflix.Show();
        }

        private void Disney_Click(object sender, RoutedEventArgs e)
        {
            Viewer disney = new Viewer("http://www.disneyplus.com/");
            disney.Show();
        }

        private void Prime_Click(object sender, RoutedEventArgs e)
        {
            Viewer prime = new Viewer("http://www.amazon.com/primevideo/");
            prime.Show();
        }

        private void Starz_Click(object sender, RoutedEventArgs e)
        {
            Viewer starz = new Viewer("http://www.starz.com/");
            starz.Show();
        }

        private void Peacock_Click(object sender, RoutedEventArgs e)
        {
            Viewer peacock = new Viewer("http://www.peacocktv.com/");
            peacock.Show();
        }
    }
}




