using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class ElementToBuy
    {
        public int Index { get; set; }
        public String ElementName { get; set; }
        public String Presentation { get; set; }
        public String Concentration { get; set; }
        public int Quantity { get; set; }
        public String PriceOrder { get; set; }
        public DateTime ExpireDate { get; set; }

        public ElementToBuy()
        {

        }
    }
}
