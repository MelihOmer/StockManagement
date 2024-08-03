namespace StockManagement.Web.Entities
{
    public class Order : BaseEntity
    {
        public string OrderNote { get; set; }
        public string OrderStatus { get; set; }
        public int StoreId { get; set; }
        public Store Store { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
}
