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

namespace VulcanStocksKNNResearch
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        PropertyManager pmg = new PropertyManager();
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Content= new HomePage();
            this.DataContext=pmg;
        }
        private void BTCloseClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BTSettingsClick(object sender, RoutedEventArgs e)
        {   
            MainFrame.Content = new Settings();
            pmg.NotchDisplay="Settings";
        }

        private void BTTestBEClick(object sender, RoutedEventArgs e)
        {
            pmg.NotchDisplay="Test best entry";
        }

        private void BTManualClick(object sender, RoutedEventArgs e)
        {
            pmg.NotchDisplay="Manual entry";
        }

        private void BTDemoClick(object sender, RoutedEventArgs e)
        {
            pmg.NotchDisplay="Demotrading";
            MainFrame.Content = new Demotrading();
        }

        private void BTLogoClick(object sender, RoutedEventArgs e)
        {
            pmg.NotchDisplay="Homepage";
            MainFrame.Content = new HomePage();
        }
    }
}
