using OPBO.CoreBuisiness;
using OPBO.UseCases.PluginInterfaces;

namespace OPBO.UseCases
{
    public class ViewOrdersSummaryUseCase :IViewOrdersSummaryUseCase
    { 

        private readonly IOrderRepository _orderRepository;
        public ViewOrdersSummaryUseCase(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }
        public async Task<IEnumerable<OrderSummary>> ExecuteAsync()
        {
            return await _orderRepository.GetOrdersSummaryAsync();

        }
    }
}