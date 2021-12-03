using Currency.Api.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System;
using Currency.Contract.DTO;

namespace Currency.Api.Repositories
{

    /// <summary>
    /// Repository for storing currencies in database
    /// </summary>
    /// <seealso cref="currenciesAPI.Repositories.ICurrencyRepository" />
    public class CurrencyRepository : ICurrencyRepository
    {

        /// <summary>
        /// Gets the list of currencies from database.
        /// </summary>
        /// <returns></returns>
        public Task<IEnumerable<CurrencyDto>> GetListOfCurrenciesFromDatabase()
        {
            // get from sql database
            throw new NotImplementedException();
        }
    }
}
