using OPBO.CoreBuisiness;

namespace OPBO.UseCases
{
    public interface IViewOrdersUseCase
    {
        Task<IEnumerable<Order>> ExecuteAsync(string searchTerm);
    }
}