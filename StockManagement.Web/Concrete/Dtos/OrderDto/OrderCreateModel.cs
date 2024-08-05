namespace StockManagement.Web.Concrete.Dtos.OrderDto
{
    public class OrderCreateModel
    {
        public string OrderNote { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.Now;

    }
}
