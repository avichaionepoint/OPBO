using OPBO.CoreBuisiness;
using OPBO.UseCases.PluginInterfaces;

namespace OPBO.Plugins.InMemory
{
    public class OrderRepository : IOrderRepository
    {
        List<Order> _orders;
        List<OrderSummary> _orderSummary;
        public OrderRepository()
        {
            _orders = new List<Order>()
            {
                new Order(){ Id="1",CreateDate = DateTime.Now,FirstName="avichai",Total=(decimal)1345.54,BranchCode=1,DocNo="1111"},
                new Order(){ Id="2",CreateDate = DateTime.Now,FirstName="avichai2",Total=(decimal)345.54,BranchCode=1,DocNo="1111"},
                new Order(){ Id="3",CreateDate = DateTime.Now,FirstName="avichai3",Total=(decimal)545.54,BranchCode=1,DocNo="1111"},
                new Order(){ Id="4",CreateDate = DateTime.Now,FirstName="avichai4",Total=(decimal)845.54,BranchCode=1,DocNo="1111"},
                new Order(){ Id="5",CreateDate = DateTime.Now.AddDays(-1),FirstName="avichai5",Total=(decimal)345.54,BranchCode=1,DocNo="1111"}

            };

            _orderSummary = new List<OrderSummary>()
            {
                new OrderSummary(){ BranchNo=1,Ok=10,Bad=0},
                new OrderSummary(){ BranchNo=2,Ok=11,Bad=1},
                new OrderSummary(){ BranchNo=3,Ok=10,Bad=0}

            };
        }
        public async Task<IEnumerable<Order>> GetOrdersByDateAsync(string date)
        {
            if(string.IsNullOrEmpty(date))
                return await Task.FromResult(_orders);

            return await Task.FromResult(_orders.Where(x=>x.Id==date || x.DocNo==date));

        }
        public async Task<IEnumerable<OrderSummary>> GetOrdersSummaryAsync()
        {
            return await Task.FromResult(_orderSummary);
        }
        public async Task<Order> GetOrderByIdAsync(string id)
        {

            Order order = _orders.First(x => x.Id == id);
            order.Address = new OrderAddress()
            {
                City = "jerusalem",
                Street = "koboni",
                Zip = "90210"
            };
            order.Payment = new OrderPayment()
            {
                CardNymber = "4343434",
                CardType = "Max",
                PaymentNum = 1
            };

            order.Items = new List<OrderItem>();
            order.Items.Add(new OrderItem() { 
                LineNumber = 1,
                Name = "shsh",
                Price = (decimal)12.3,
                Quantity = 1,
                Total = (decimal)13.23
            });
            order.Items.Add(new OrderItem()
            {
                LineNumber = 2,
                Name = "shsdsdsdh",
                Price = (decimal)5.3,
                Quantity = 1.6,
                Total = (decimal)123.23
            });
            return await Task.FromResult(order);
        }
    }
}