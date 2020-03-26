using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
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
            loadb();


        }



       
        public void loadb()
        {
            
            string path = @"ab12.xml";
            var str = File.ReadAllText(path);
            string text = str;
            string searchTerm = "weight>";
            string value = string.Empty;
            int pos = text.IndexOf(searchTerm);
            if (pos >= 0)
            {
                string temp = text.Substring(pos + searchTerm.Length).Trim();
                string[] parts = temp.Split(' ');
                value = parts[0];
                if (value.Contains('<'))
                    value = value.Substring(0, value.LastIndexOf('<'));
               
            }
            var str1 = File.ReadAllText(path);
            string text1 = str;
            string searchTerm1 = "height>";
            string value1 = string.Empty;
            int pos1 = text.IndexOf(searchTerm1);
            if (pos1 >= 0)
            {
                string temp = text.Substring(pos1 + searchTerm1.Length).Trim();
                string[] parts = temp.Split(' ');
                value1 = parts[0];
                if (value1.Contains('<'))
                    value1 = value1.Substring(0, value1.LastIndexOf('<'));
               
            }
            var str2 = File.ReadAllText(path);
            string text2 = str;
            string searchTerm2 = "age>";
            string value2 = string.Empty;
            int pos2 = text.IndexOf(searchTerm2);
            if (pos2 >= 0)
            {
                string temp = text.Substring(pos2 + searchTerm2.Length).Trim();
                string[] parts = temp.Split(' ');
                value2 = parts[0];
                if (value2.Contains('<'))
                    value2 = value2.Substring(0, value2.LastIndexOf('<'));
                

            }
            var str3 = File.ReadAllText(path);
            string text3 = str;
            string searchTerm3 = "smoke>";
            string value3 = string.Empty;
            int pos3 = text.IndexOf(searchTerm3);
            if (pos3 >= 0)
            {
                string temp = text.Substring(pos3 + searchTerm3.Length).Trim();
                string[] parts = temp.Split(' ');
                value3 = parts[0];
                if (value3.Contains('<'))
                    value3 = value3.Substring(0, value3.LastIndexOf('<'));
                if (value2.Contains('<'))
                    value3 = value3.Substring(0, value3.LastIndexOf('<'));

            }


            try
            {
                int numVal = Int32.Parse(value);
                int numVal1 = Int32.Parse(value1);

                Random rnd = new Random();
                int bmr = rnd.Next(1, 60);
                


                numVal = numVal / 4 + numVal1 / 8 + bmr ;

                if (value3.Equals("YES</smoke>"))
                {
                    numVal = numVal + 50;
                }

                test.Text = numVal.ToString();
                PBar.Value = numVal;

                if (numVal <= 40)
                  test1.Text = ("Rate you very few eat more fruits");
                 if (numVal > 80)
                   test1.Text = ("Rate you very good");
                 else
                  test1.Text = ("Rate you good eat more meat");

               

            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }


            File.Delete(path);

        }
    }
}
