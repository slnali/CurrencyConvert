using System;
using System.Threading.Tasks;

namespace Currency.Api.Repositories
{
    /// <summary>
    /// The "Production" implementation of the IExchangeRepository interface
    /// </summary>
    /// <seealso cref="Repositories.IExchangeRepository" />
    public class ExchangeRepository : IExchangeRepository
    {
        /// <summary>
        /// Get the exchange rate for the fromCurrency to the toCurrency.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<float> GetExchangeRate(string fromCurrency, string toCurrency)
        {
            throw new NotImplementedException();
        }
    }
}
