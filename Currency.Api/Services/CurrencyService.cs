using Currency.Api.Repositories;
using Currency.Contract.DTO;
using Currency.Contract.Requests;
using Currency.Contract.Responses;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Currency.Api.Services
{
    /// <summary>
    /// currencies service implementing service pattern which contacts various repositories for processing/storng/getting
    /// </summary>
    /// <seealso cref="ICurrencyService" />
    public class CurrencyService : ICurrencyService
    {
        private readonly IExchangeRepository exchangeRepository;
        private readonly ICurrencyRepository currencyRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="CurrencyService"/> class.
        /// </summary>
        /// <param name="exchangeRepository">The exchange repository.</param>
        /// <param name="currencyRepository">The currency repository.</param>
        public CurrencyService(IExchangeRepository exchangeRepository, ICurrencyRepository currencyRepository)
        {
            this.exchangeRepository = exchangeRepository;
            this.currencyRepository = currencyRepository;
        }

        /// <summary>
        /// Converts the currency asynchronously.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public async Task<CurrencyConvertResult> ConvertCurrencyAsync(CurrencyConvertRequest request)
        {
            float exchangeRate = await this.exchangeRepository.GetExchangeRate(request.FromCurrency, request.ToCurrency).ConfigureAwait(false);
            var convertedResult = request.Amount * exchangeRate;
            return new CurrencyConvertResult(convertedResult, exchangeRate);
        }

        /// <summary>
        /// Gets the currencies list.
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<CurrencyDto>> GetCurrenciesList()
        {
            var currencies = await currencyRepository.GetListOfCurrenciesFromDatabase().ConfigureAwait(false);
            return currencies;
        }
    }
}
