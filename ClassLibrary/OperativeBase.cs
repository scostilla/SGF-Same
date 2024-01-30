using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class OperativeBase
    {
        public int Id { get; set; }
        public string BaseName { get; set; }
        public string Locality { get; set; }
        public string Address { get; set; }
        public List<Element> elementlist { get; set; }

        public OperativeBase()
        {

        }

        public OperativeBase(int id, string baseName, string locality, string address, List<Element> elementlist)
        {
            Id = id;
            BaseName = baseName;
            Locality = locality;
            Address = address;
            this.elementlist = elementlist;
        }
    }
}
