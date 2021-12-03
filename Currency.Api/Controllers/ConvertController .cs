using Currency.Api.Services;
using Currency.Contract.Requests;
using Currency.Contract.Responses;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace Currency.Api.Controllers
{
    #region CurrenciesController
    /// <summary>
    /// Implemens convert controller 
    /// </summary>
    /// <seealso cref="ControllerBase" />
    [Route("api/[controller]")]
    [ApiController]
    public class ConvertController : ControllerBase
    {
        private readonly ICurrencyService currencyService;

        /// <summary>
        /// Initializes a new instance of the <see cref="ConvertController"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        /// <param name="currencyService">The currency service.</param>
        public ConvertController(ICurrencyService currencyService)
        {
            this.currencyService = currencyService;
        }
        #endregion

        /// <summary>
        /// Gets the converted currency result.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult<CurrencyConvertResult>> GetConvertedCurrencyResult(
            [FromBody][Required] CurrencyConvertRequest request)
        {
            var convertResult = await currencyService.ConvertCurrencyAsync(request).ConfigureAwait(false);
            return Ok(convertResult);
        }
    }
}