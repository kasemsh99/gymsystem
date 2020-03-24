﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.IO;
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
    /// Interaction logic for Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();
            load();
        }

        private void resrt_click(object sender, RoutedEventArgs e)
        {
            this.checkbox1.IsChecked = this.checkbox2.IsChecked = this.checkbox3.IsChecked = this.checkbox4.IsChecked = this.checkbox5.IsChecked = this.checkbox6.IsChecked =
                this.checkbox6.IsChecked = this.checkbox7.IsChecked = this.checkbox8.IsChecked = this.checkbox9.IsChecked = this.checkbox10.IsChecked = false;
            blood.SelectedIndex = smoke.SelectedIndex = -1;
            weight.Text = height.Text = age.Text = string.Empty;
        }

        public void load()
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

                name1.Text = value;

            }

            string searchTerm2 = "family>";
            string value2 = string.Empty;
            int pos2 = text.IndexOf(searchTerm2);
            if (pos2 >= 0)
            {
                string temp = text.Substring(pos2 + searchTerm2.Length).Trim();
                string[] parts = temp.Split(' ');
                value2 = parts[0];
                if (value2.Contains('<'))
                    value2 = value2.Substring(0, value2.LastIndexOf('<'));

                name2.Text = value2;

            }

            File.Delete(path);

        }
    }
}
