﻿using Currency.Api.Services;
using Currency.Contract.DTO;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Currency.Api.Controllers
{
    #region CurrenciesController
    /// <summary>
    /// Implemens Payment controller gateway for receiving api requests from Merchants
    /// </summary>
    /// <seealso cref="ControllerBase" />
    [Route("api/[controller]")]
    [ApiController]
    public class CurrenciesController : ControllerBase
    {
        private readonly ICurrencyService currencyService;

        /// <summary>
        /// Initializes a new instance of the <see cref="ConvertController"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        /// <param name="paymentsService">The payments service.</param>
        public CurrenciesController(ICurrencyService currencyService)
        {
            this.currencyService = currencyService;
        }
        #endregion

        /// <summary>
        /// Gets the list of supported currencies.
        /// </summary>
        /// <returns>List of supported currencies.</returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CurrencyDto>>> GetListOfCurrencies()
        {
            var payments = await currencyService.GetCurrenciesList().ConfigureAwait(false);
            return Ok(payments);
        }
    }
}