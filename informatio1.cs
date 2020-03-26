using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class informatio1
    {
        private string txtdata1;
        private string txtdata2;
        private string txtdata3;
        private string txtdata4;

        public string weight
        {
            get { return txtdata1; }
            set { txtdata1 = value; }
        }

        public string height
        {
            get { return txtdata2; }
            set { txtdata2 = value; }
        }

        public string age
        {
            get { return txtdata3; }
            set { txtdata3 = value; }
        }
        
             public string smoke
        {
            get { return txtdata4; }
            set { txtdata4 = value; }
        }
    }
}
