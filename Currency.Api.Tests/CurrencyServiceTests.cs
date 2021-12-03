using Currency.Api.Repositories;
using Currency.Api.Services;
using Currency.Api.StubData;
using System.Threading.Tasks;
using Xunit;
using FluentAssertions;
using Currency.Contract.Requests;
using System.Linq;
using Currency.Contract.DTO;

namespace Currency.Api.Tests
{
    /// <summary>
    /// Test currencies service class.
    /// </summary>
    public class CurrencyServiceTests
    {
        private CurrencyService currencyService;
        private readonly IExchangeRepository mockExchangeRepository;
        private readonly ICurrencyRepository currencyRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="CurrencyServiceTests"/> class.
        /// </summary>
        public CurrencyServiceTests()
        {
            currencyRepository = new MockCurrencyRepository();
            mockExchangeRepository = new MockExchangeRepository();
            currencyService = new CurrencyService(mockExchangeRepository, currencyRepository);
        }


        /// <summary>
        /// Retrieving the currencies succeeds asynchronously.
        /// </summary>
        [Fact]
        public async Task RetrievingCurrenciesSucceedsAsync()
        {
            var currencies = await currencyService.GetCurrenciesList();
            currencies.Should().NotBeEmpty();
            currencies.Should().HaveCount(ReferenceData.Currencies.Length);
        }

        /// <summary>
        /// Calculating the currency conversion is successful asynchronously.
        /// </summary>
        [Fact]
        public async Task CalculatingCurrencyConversionIsSuccessfulAsync()
        {
            var request = new CurrencyConvertRequest("GBP", "USD", 1.0f);
            var convertResult = await currencyService.ConvertCurrencyAsync(request).ConfigureAwait(false);
            convertResult.Should().NotBeNull();
            convertResult.Rate.Should().BeGreaterThan(0);
            convertResult.Result.Should().BeGreaterThan(1.0f);
        }
    }
}
