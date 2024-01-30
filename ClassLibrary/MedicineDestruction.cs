using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class MedicineDestruction
    {
        public int Id { get; set; }
        public String ReportNumber { get; set; }
        public String City { get; set; }
        public String BaseName { get; set; }
        public String RequestedBy { get; set; }
        public DateTime RequestedDate { get; set; }
        public String ElementList { get; set; }
        public String State { get; set; }

        public MedicineDestruction()
        {
        }
    }
}
