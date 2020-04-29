namespace CIS_560_Proj.Items
{
    public class ProductionHouse
    {
        public int ProductionId { get; }
        public string ProductionName { get; }
        public string Location { get; }
        public string Deleted { get; }



        public ProductionHouse(int productionId, string productionname, string location, string Deleted)
        {
            this.ProductionId = productionId;
            this.ProductionName = productionname;
            this.Location = location;
            this.Deleted = Deleted;
        }
    }
}
