using OPBO.CoreBuisiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPBO.UseCases.PluginInterfaces
{
    public interface IOrderRepository
    {
     
        Task<IEnumerable<Order>> GetOrdersByDateAsync(string date);
        Task<IEnumerable<OrderSummary>> GetOrdersSummaryAsync
            ();
        Task<Order> GetOrderByIdAsync(string id);

    }
}
