using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class ControlSheetTotals
    {
        public int IdControlSheetTotals { get; set; }
        public int OperationalMonth { get; set; }
        public int OperationaYear { get; set; }
        public String Vehicle { get; set; }

        public List<ElementQuantity> Elements = new List<ElementQuantity>();

        public ControlSheetTotals()
        {

        }
    }
}
