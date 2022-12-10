using OPBO.CoreBuisiness;

namespace OPBO.UseCases
{
    public interface IViewOrderDetailsUseCase
    {
        Task<Order> ExecuteAsync(string id);
    }
}