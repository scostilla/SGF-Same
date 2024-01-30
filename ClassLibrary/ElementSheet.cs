using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class ElementSheet
    {
        public int Id { get; set; }
        public DateTime OperationalDay { get; set; }
        public string Nurse { get; set; }
        public String ElementName { get; set; }
        public int Quantity { get; set; }

        public ElementSheet()
        {

        }
    }
}
