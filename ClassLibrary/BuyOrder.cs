using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class BuyOrder
    {
        public int Id { get; set; }
        public int BuyOrderNumber { get; set; }
        public int BuyOrderYear { get; set; }
        public String City { get; set; }
        public DateTime RequestDate { get; set; }
        public String Destiny { get; set; }
        public String ToUseIn { get; set; }
        public String RequestedBy { get; set; }

        public List<ElementToBuy> elementList = new List<ElementToBuy>();
        public String authorized { get; set; }
        public int AuthorizationNumber { get; set; }
        public int AuthorizationYear { get; set; }
        public String authorizedBy { get; set; }
        public DateTime authorizationDate { get; set; }
        public int IdRole { get; set; }

        public BuyOrder()
        {

        }
    }
}
