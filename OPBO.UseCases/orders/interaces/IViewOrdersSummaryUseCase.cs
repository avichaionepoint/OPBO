using OPBO.CoreBuisiness;

namespace OPBO.UseCases
{
    public interface IViewOrdersSummaryUseCase
    {
        Task<IEnumerable<OrderSummary>> ExecuteAsync();
    }
}