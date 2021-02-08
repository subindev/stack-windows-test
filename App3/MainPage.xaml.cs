using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace App3
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            webview.Source = new Uri(urlBox.Text);
        }
        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            webview1.Source = new Uri(urlBox1.Text);
        }
        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            webview2.Source = new Uri(urlBox2.Text);
        }
        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            webview3.Source = new Uri(urlBox3.Text);
        }
    }
}
