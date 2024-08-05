using StockManagement.Web.Entities;

namespace StockManagement.Web.Concrete.Dtos.StoreAndOrders
{
    public class StoreAndOrdersDto
    {
        public StoreInfo Store{ get; set; }
        public int PendingOrders{ get; set; }
        public int CompletedOrders{ get; set; }
        public int TotalOrders{ get; set; }
    }
}
