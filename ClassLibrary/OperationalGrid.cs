using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class OperationalGrid
    {
        public int Id { get; set; }
        public int OperationalMonth { get; set; }
        public int OperationaYear { get; set; }
        public String Vehicle { get; set; }
        public List<Nurse> nurses = new List<Nurse>();

        public OperationalGrid()
        {

        }
    }
}
