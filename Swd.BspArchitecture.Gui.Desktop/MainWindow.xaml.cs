using Swd.BspArchitecture.Business;
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

namespace Swd.BspArchitecture.Gui.Desktop
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

        private void btnShowText_Click(object sender, RoutedEventArgs e)
        {
            BusinessFactory factory = new BusinessFactory();
            string text2Show = factory.GetBusinessData();
            this.lblTextToShow.Content = text2Show;
        }
    }
}
