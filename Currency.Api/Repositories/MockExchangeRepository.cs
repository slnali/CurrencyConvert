using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Currency.Api.Repositories
{
    /// <summary>
    /// Class to inject for mocking Exchange repository in unit tests
    /// </summary>
    /// <seealso cref="Currency.Api.Repositories.IExchangeRepository" />
    public class MockExchangeRepository : IExchangeRepository
    {
        private Dictionary<string, Dictionary<string, float>> CurrencyToExchangeRate { get; } =
            new Dictionary<string, Dictionary<string, float>>
            {
                {
                    "USD",
                    new Dictionary<string, float>
                    {
                        {"GBP", 0.75F},
                        {"HKD", 7.80F},
                        {"EUR", 0.88F},
                    }
                },
                {
                    "GBP",
                    new Dictionary<string, float>
                    {
                        {"USD", 1.33F},
                        {"HKD", 10.36F},
                        {"EUR", 1.17F},
                    }
                },
                {
                    "EUR",
                    new Dictionary<string, float>
                    {
                        {"USD", 1.13F},
                        {"HKD", 8.83F},
                        {"GBP", 0.85F},
                    }
                },
                {
                    "HKD",
                    new Dictionary<string, float>
                    {
                        {"GBP", 0.09F},
                        {"USD", 0.13F},
                        {"EUR", 0.11F},
                    }
                },
            };

        /// <summary>
        /// Gets exchange rate through the "Mock" Exchange.
        /// </summary>
        /// <returns></returns>
        public Task<float> GetExchangeRate(string fromCurrency, string toCurrency)
        {
            this.CurrencyToExchangeRate.TryGetValue(fromCurrency, out var fromCurrencyRates);
            fromCurrencyRates.TryGetValue(toCurrency, out var exchangeRate);
            return Task.FromResult(exchangeRate);
        }
    }
}
