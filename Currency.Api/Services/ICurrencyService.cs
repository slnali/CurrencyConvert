using Currency.Contract.DTO;
using Currency.Contract.Requests;
using Currency.Contract.Responses;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Currency.Api.Services
{
    public interface ICurrencyService
    {
        Task<IEnumerable<CurrencyDto>> GetCurrenciesList();

        Task<CurrencyConvertResult> ConvertCurrencyAsync(CurrencyConvertRequest request);
    }
}