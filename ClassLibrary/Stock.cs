using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Stock
    {
        public int Id { get; set; }
        public int InOut { get; set; } //       0= in - 1= out
        public DateTime EntryDate { get; set; }
        public int Id_provider { get; set; }
        public int Id_base { get; set; }
        public int Id_element { get; set; }
        public int Quantity { get; set; }
        public int Total { get; set; } //       total from database
        public String Lot { get; set; }
        public DateTime ExpireDate { get; set; }
        public int Residue { get; set; } //     to replace in the database total
        public string Remit { get; set; }
        public string Observations { get; set; }

        public Stock()
        {

        }
    }
}
