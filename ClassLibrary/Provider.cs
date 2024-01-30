using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Provider
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Province { get; set; }
        public string Address { get; set; }

        public Provider(string name, string province, string address)
        {
            Name = name;
            Province = province;
            Address = address;
        }

        public Provider()
        {

        }
    }
}
