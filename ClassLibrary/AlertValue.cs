using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class AlertValue
    {
        public int Id { get; set; }
        public int Id_base { get; set; }
        public int Id_element { get; set; }
        public int Quantity { get; set; }

        public AlertValue()
        {

        }

        public AlertValue(int id, int id_base, int id_element, int quantity)
        {
            Id = id;
            Id_base = id_base;
            Id_element = id_element;
            Quantity = quantity;
        }
    }
}
