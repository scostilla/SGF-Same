using System;

namespace ClassLibrary
{
    public class ElementModel
    {
        public int Id { get; set; }
        public string ElementName { get; set; }
        public string Concentration { get; set; }
        public string Presentation { get; set; }
        public int Total { get; set; }
        public string Uses { get; set; }
        public string Observations { get; set; }

        public ElementModel()
        {
        }

        public ElementModel(int id, string elementName, string concentration, string presentation, int total, string use, string observations)
        {
            Id = id;
            ElementName = elementName;
            Concentration = concentration;
            Presentation = presentation;
            Total = total;
            Uses = use;
            Observations = observations;
        }
    }
}
