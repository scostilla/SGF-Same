using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class BaseStock
    {
        public int Id { get; set; }
        public int IdBase { get; set; }
        public int IdElement { get; set; }
        public int Quantity { get; set; }

        public BaseStock()
        {

        }

        public BaseStock(int id, int idBase, int idElement, int quantity)
        {
            Id = id;
            IdBase = idBase;
            IdElement = idElement;
            Quantity = quantity;
        }
    }
}
