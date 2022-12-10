using OPBO.CoreBuisiness;
using OPBO.UseCases.PluginInterfaces;

namespace OPBO.UseCases
{
    public class ViewOrdersUseCase : IViewOrdersUseCase
    {
        private readonly IOrderRepository _orderRepository;
        public ViewOrdersUseCase(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }
        public async Task<IEnumerable<Order>> ExecuteAsync(string searchTerm)
        {
            return await _orderRepository.GetOrdersByDateAsync(searchTerm);

        }
    }
}