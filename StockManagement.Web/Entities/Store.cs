namespace StockManagement.Web.Entities
{
    public class Store : BaseEntity
    {
        public string StoreName { get; set; }
        public string StoreCode { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public List<Order>? Orders { get; set; }
    }
}
