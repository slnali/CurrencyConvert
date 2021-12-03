using Currency.Api.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System;
using Currency.Api.StubData;
using System.Linq;
using Currency.Contract.DTO;

namespace Currency.Api.Repositories
{

    /// <summary>
    /// Repository for storing payments in database
    /// </summary>
    /// <seealso cref="PaymentsAPI.Repositories.IPaymentRepository" />
    public class MockCurrencyRepository : ICurrencyRepository
    {
        /// <summary>
        /// Gets the list of payments from database.
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<CurrencyDto>> GetListOfCurrenciesFromDatabase()
        {
            return await Task.FromResult(
                ReferenceData.Currencies.ToList().Select(
                    currency => new CurrencyDto(currency.Name, currency.Symbol))).ConfigureAwait(false);
        }
    }
}
