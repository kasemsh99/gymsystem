using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
   public class infomation
    {
        private string txtdata1;
        private string txtdata2;
        private string txtdata3;
        private string txtdata4;
        private string txtdata5;
        private string txtdata6;
        

        public string name
        {
            get { return txtdata1; }
            set { txtdata1 = value; }
        }

        public string family
        {
            get { return txtdata2; }
            set { txtdata2 = value; }
        }

        public string day
        {
            get { return txtdata3; }
            set { txtdata3 = value; }
        }

        public string month
        { 
            get { return txtdata4; }
            set { txtdata4 = value; }
        }
        public string year
        {
            get { return txtdata5; }
            set { txtdata5 = value; }
        }
        public string country
        {
            get { return txtdata6; }
            set { txtdata6 = value; }
        }
        

    }
}
