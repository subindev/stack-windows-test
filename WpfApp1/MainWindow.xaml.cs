using Microsoft.Web.WebView2.Wpf;
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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<string> websites = new List<string>()
        {
            "https://www.microsoft.com",
            "https://apple.com",
            "https://youtube.com",
            "https://office.com",
            "https://netflix.com"
        };

        Random rnd = new Random();

        public MainWindow()
        {
            InitializeComponent();
        }
        private void myButton_Click(object sender, RoutedEventArgs e)
        {
            var webview = new WebView2()
            {
                Source = new Uri(websites[rnd.Next(0, websites.Count -1)]),
            };
            var newgrid = new Grid()
            {
                Margin = new Thickness(5),
                Width = 500
            };
            newgrid.Children.Add(webview);
            stackPanel.Children.Add(newgrid);
        }
    }
}
