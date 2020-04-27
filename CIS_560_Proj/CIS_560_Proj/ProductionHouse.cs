using System;
using System.Collections.Generic;
using System.Text;

namespace _560.Models
{
    public class ProductionHouse
    {
        public int ProductionId { get; }
        public string ProductionName { get;}
        public string Location { get; }


        public ProductionHouse(int productionId, string productionname,string location)
        {
            this.ProductionId = productionId;
            this.ProductionName = productionname;
            this.Location = location;
        }
    }
}
