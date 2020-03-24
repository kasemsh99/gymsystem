using System;
using System.Xml;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Linq;
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
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void goto_Click(object sender, RoutedEventArgs e)
        {
            Uri uri = new Uri("PAGE2.xaml", UriKind.Relative);
            this.NavigationService.Navigate(uri);
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void savebtn_click(object sender, RoutedEventArgs e)
        {
            try
            {
                infomation info = new infomation();
                info.name = name.Text;
                info.family = family.Text;
                info.day = day.Text;
                info.month = month.Text;
                info.year = year.Text;
                info.country = country.Text;



                Database.savedata(info, "bc12356.xml");

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void loadbtn_click(object sender, RoutedEventArgs e)
        {
            string path = @"bc12356.xml";
            var str = File.ReadAllText(path);
            string text = str;
            string searchTerm = "name>";
            string value = string.Empty;
            int pos = text.IndexOf(searchTerm);
            if (pos >= 0)
            {
                string temp = text.Substring(pos + searchTerm.Length).Trim();
                string[] parts = temp.Split(' ');
                value = parts[0];
                if (value.Contains('<'))
                    value = value.Substring(0, value.LastIndexOf('<'));

                name.Text = value;

            }

            string searchTerm1 = "family>";
            string value1 = string.Empty;
            int pos1 = text.IndexOf(searchTerm1);
            if (pos1 >= 0)
            {
                string temp = text.Substring(pos1 + searchTerm1.Length).Trim();
                string[] parts = temp.Split(' ');
                value1 = parts[0];
                if (value1.Contains('<'))
                    value1 = value1.Substring(0, value1.LastIndexOf('<'));
                family.Text = value1;

            }

            string searchTerm2 = "day>";
            string value2 = string.Empty;
            int pos2 = text.IndexOf(searchTerm2);
            if (pos2 >= 0)
            {
                string temp = text.Substring(pos2 + searchTerm2.Length).Trim();
                string[] parts = temp.Split(' ');
                value2 = parts[0];
                if (value2.Contains('<'))
                    value2 = value2.Substring(0, value2.LastIndexOf('<'));
                day.Text = value2;

            }

            string searchTerm3 = "month>";
            string value3 = string.Empty;
            int pos3 = text.IndexOf(searchTerm3);
            if (pos3 >= 0)
            {
                string temp = text.Substring(pos3 + searchTerm3.Length).Trim();
                string[] parts = temp.Split(' ');
                value3 = parts[0];
                if (value3.Contains('<'))
                    value3 = value3.Substring(0, value3.LastIndexOf('<'));
                month.Text = value3;

            }

            string searchTerm4 = "country>";
            string value4 = string.Empty;
            int pos4 = text.IndexOf(searchTerm4);
            if (pos4 >= 0)
            {
                string temp = text.Substring(pos4 + searchTerm4.Length).Trim();
                string[] parts = temp.Split(' ');
                value4 = parts[0];
                if (value4.Contains('<'))
                    value4 = value4.Substring(0, value4.LastIndexOf('<'));
                if (value4.Contains('<'))
                    value4 = value4.Substring(0, value4.LastIndexOf('<'));
                country.Text = value4;

            }

            
        }

    }
    }


