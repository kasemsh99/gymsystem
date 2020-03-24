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
    /// Interaction logic for Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        public Page3()
        {
            InitializeComponent();
        }

        private void PBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            int bmr;
            bmr = 66 + (13 * 60)/100 + (5 * 106)/100 - (6 * 20)/ 100;
            PBar.Value = bmr;


        }
    }
}
