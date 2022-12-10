using OPBO.CoreBuisiness;
using OPBO.UseCases.PluginInterfaces;

namespace OPBO.UseCases
{
    public class ViewOrderDetailsUseCase : IViewOrderDetailsUseCase
    {
        private readonly IOrderRepository _orderRepository;
        public ViewOrderDetailsUseCase(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }
        public async Task<Order> ExecuteAsync(string id)
        {
            return await _orderRepository.GetOrderByIdAsync(id);

        }
    }
}