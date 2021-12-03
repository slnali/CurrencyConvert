using System.Threading.Tasks;

namespace Currency.Api.Repositories
{
    /// <summary>
    /// Interface for defining behaviour of Exchange repository
    /// Currently allows us to create a mock which implements the same and allows us to inject in unit tests
    /// Also allows us to create a "production" implementation where actual Exchange data is retrieved
    /// </summary>
    public interface IExchangeRepository
    {
        /// <summary>
        /// Processes the payment.
        /// </summary>
        /// <param name="payment">The payment.</param>
        /// <returns></returns>
        Task<float> GetExchangeRate(string fromCurrency, string toCurrency);
    }
}
