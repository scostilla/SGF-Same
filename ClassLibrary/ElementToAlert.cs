using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class ElementToAlert
    {
        public int IdElementToAlert { get; set; }
        public String BarCode { get; set; }
        public String Name { get; set; }
        public String Concentration { get; set; }
        public String Presentation { get; set; }
        public int Total { get; set; }
        public int Alert { get; set; }

        public ElementToAlert()
        {

        }
    }
}
