namespace StockManagement.Web.Entities
{
    public class Product : BaseEntity
    {
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public string Unit { get; set; }
        public decimal UnitStock{ get; set; }
        public decimal Stock { get; set; }
        public bool Active { get; set; }
    }
}
