using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class StockList
    {
        public String ProviderName { get; set; }
        public String ElementName { get; set; }
        public String Lot { get; set; }
        public DateTime ExpireDate { get; set; }
        public String BarCode { get; set; }
        public int Quantity { get; set; }
        public String OperativeBase { get; set; }
        public DateTime EntryDate { get; set; }
        public String Remit { get; set; }


        public StockList()
        {

        }
    }
}
