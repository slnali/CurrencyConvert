using Currency.Contract.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Currency.Api.Repositories
{
    /// <summary>
    /// ICurrencyRepository.
    /// </summary>
    public interface ICurrencyRepository
    {
        /// <summary>
        /// Gets the list of currencies from database.
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<CurrencyDto>> GetListOfCurrenciesFromDatabase();
    }
}