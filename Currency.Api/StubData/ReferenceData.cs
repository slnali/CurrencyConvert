using Currency.Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace Currency.Api.StubData
{
    public class ReferenceData
    {
        public static Models.Currency[] Currencies { get; } = {
                        new Models.Currency
                        (
                            id:1,
                            symbol: "GBP",
                            name: "Pound Sterling"
                        ),
                        new Models.Currency
                        (
                            id:2,
                            symbol: "USD",
                            name: "United States Dollar"
                        ),
                        new Models.Currency
                        (
                            id:3,
                            symbol: "EUR",
                            name: "Euro"
                        ),
                        new Models.Currency
                        (
                            id:4,
                            symbol: "HKD",
                            name: "Hong Kong Dollar"
                        )};
    }
}
