using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class ControlSheet
    {
        public int Id { get; set; }
        public int OperationalGridId { get; set; }

        public List<ElementSheet> Detail = new List<ElementSheet>();

        public ControlSheet()
        {

        }
    }
}
