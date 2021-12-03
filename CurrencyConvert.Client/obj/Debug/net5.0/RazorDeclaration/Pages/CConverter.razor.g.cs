// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace CurrencyConvert.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 3 "/Users/nal/Documents/Repos/CurrencyConvert/CurrencyConvert.Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/nal/Documents/Repos/CurrencyConvert/CurrencyConvert.Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/nal/Documents/Repos/CurrencyConvert/CurrencyConvert.Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/nal/Documents/Repos/CurrencyConvert/CurrencyConvert.Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/nal/Documents/Repos/CurrencyConvert/CurrencyConvert.Client/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/nal/Documents/Repos/CurrencyConvert/CurrencyConvert.Client/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/nal/Documents/Repos/CurrencyConvert/CurrencyConvert.Client/_Imports.razor"
using CurrencyConvert.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/nal/Documents/Repos/CurrencyConvert/CurrencyConvert.Client/_Imports.razor"
using CurrencyConvert.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/nal/Documents/Repos/CurrencyConvert/CurrencyConvert.Client/Pages/CConverter.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/nal/Documents/Repos/CurrencyConvert/CurrencyConvert.Client/Pages/CConverter.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/nal/Documents/Repos/CurrencyConvert/CurrencyConvert.Client/Pages/CConverter.razor"
using System.Threading.Tasks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/nal/Documents/Repos/CurrencyConvert/CurrencyConvert.Client/Pages/CConverter.razor"
using Currency.Contract.DTO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/nal/Documents/Repos/CurrencyConvert/CurrencyConvert.Client/Pages/CConverter.razor"
using Currency.Contract.Requests;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/nal/Documents/Repos/CurrencyConvert/CurrencyConvert.Client/Pages/CConverter.razor"
using Currency.Contract.Responses;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/nal/Documents/Repos/CurrencyConvert/CurrencyConvert.Client/Pages/CConverter.razor"
using Microsoft.Extensions.Logging;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class CConverter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 47 "/Users/nal/Documents/Repos/CurrencyConvert/CurrencyConvert.Client/Pages/CConverter.razor"
       
    private string FirstCurrencyAmount { get; set; }

    private string SecondCurrencyAmount { get; set; }

    private string FirstSelectedCurrency { get; set; }

    private string SecondSelectedCurrency { get; set; }

    private CurrencyDto[] currencies;

    protected override async Task OnInitializedAsync()
    {
        currencies = await Http.GetFromJsonAsync<CurrencyDto[]>("api/currencies").ConfigureAwait(false);
        FirstSelectedCurrency = currencies[0].Symbol;
        SecondSelectedCurrency = currencies[1].Symbol;
    }

    private async Task ApplyFirstSelectedCurrencyUpdateAsync(ChangeEventArgs args)
    {
        FirstSelectedCurrency = args.Value.ToString();
        SecondCurrencyAmount = await ConvertCurrencyAsync(FirstCurrencyAmount, FirstSelectedCurrency, SecondSelectedCurrency).ConfigureAwait(false);
    }

    private async Task ApplySecondSelectedCurrencyUpdateAsync(ChangeEventArgs args)
    {
        SecondSelectedCurrency = args.Value.ToString();
        FirstCurrencyAmount = await ConvertCurrencyAsync(SecondCurrencyAmount, SecondSelectedCurrency, FirstSelectedCurrency).ConfigureAwait(false);
    }

    private async Task UpdateAndConvertToSecondCurrencyAsync(ChangeEventArgs args)
    {
        FirstCurrencyAmount = args.Value.ToString();
        SecondCurrencyAmount = await ConvertCurrencyAsync(FirstCurrencyAmount, FirstSelectedCurrency, SecondSelectedCurrency).ConfigureAwait(false);
    }

    private async Task UpdateAndConvertToFirstCurrencyAsync(ChangeEventArgs args)
    {
        SecondCurrencyAmount = args.Value.ToString();
        FirstCurrencyAmount = await ConvertCurrencyAsync(SecondCurrencyAmount, SecondSelectedCurrency, FirstSelectedCurrency).ConfigureAwait(false);
    }

    private async Task<string> ConvertCurrencyAsync(string inputValue, string fromCurrency, string toCurrency)
    {
        if (fromCurrency == toCurrency)
        {
            return inputValue;
        }

        if (float.TryParse(inputValue, out float amount))
        {
            try
            {
                var convertRequest = new CurrencyConvertRequest(fromCurrency, toCurrency, amount);
                var convertResponse = await this.ConvertCurrencyBackendAsync(convertRequest);
                var roundedValue = Math.Round((Decimal)convertResponse.Result, 2);
                return roundedValue.ToString();
            }
            catch (HttpRequestException ex)
            {
                Logger.LogError(ex, "A HTTP exception occurred when converting a currency");
            }
        }
        return "Please enter a number.";
    }

    private async Task<CurrencyConvertResult> ConvertCurrencyBackendAsync(CurrencyConvertRequest request)
    {
        var response = await Http.PostAsJsonAsync<CurrencyConvertRequest>("api/convert", request).ConfigureAwait(false);
        //If http response code unsuccessful we log error and throw HttpRequestException.
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<CurrencyConvertResult>().ConfigureAwait(false);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILogger<CConverter> Logger { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
