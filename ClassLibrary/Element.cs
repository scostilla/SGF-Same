using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Element
    {
        public int Id { get; set; }
        public int IdElementModel { get; set; }
        public String Lot { get; set; }
        public DateTime ExpireDate { get; set; }
        public int Quantity { get; set; }
        public String BarCode { get; set; }

        public Element()
        {

        }

        public Element(int id, int idElementModel, string lot, DateTime expireDate, int quantity, String codeBar)
        {
            Id = id;
            IdElementModel = idElementModel;
            Lot = lot;
            ExpireDate = expireDate;
            Quantity = quantity;
            BarCode = codeBar;
        }
    }
}
