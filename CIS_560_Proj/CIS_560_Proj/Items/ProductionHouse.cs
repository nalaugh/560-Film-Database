namespace CIS_560_Proj.Items
{
    public class ProductionHouse
    {
        public int ProductionId { get; }
        public string ProductionName { get; }
        public string Location { get; }
        public string Deleated { get; }


        public ProductionHouse(int productionId, string productionname, string location)
        {
            this.ProductionId = productionId;
            this.ProductionName = productionname;
            this.Location = location;
        }
        public ProductionHouse(int productionId, string productionname, string location, string Deleadted)
        {
            this.ProductionId = productionId;
            this.ProductionName = productionname;
            this.Location = location;
            this.Deleated = Deleated;
        }
    }
}
