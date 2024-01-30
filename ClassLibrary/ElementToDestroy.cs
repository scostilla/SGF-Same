using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class ElementToDestroy
    {
        public int Index { get; set; }
        public string BaseName { get; set; }
        public string ElementName { get; set; }
        public string Concentration { get; set; }
        public string Presentation { get; set; }
        public string Lot { get; set; }
        public DateTime ExpireDate { get; set; }
        public int Egress { get; set; }
        public int Entry { get; set; }
        public int Pending { get; set; }
        public string Observations { get; set; }
        public int BaseStockId { get; set; }

        public ElementToDestroy()
        {

        }
    }
}
