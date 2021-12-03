using System.ComponentModel.DataAnnotations;

namespace Currency.Contract.Requests
{
    /// <summary>
    /// CurrencyConvertRequest.
    /// </summary>
    public class CurrencyConvertRequest
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="CurrencyConvertRequest"/> class.
        /// </summary>
        /// <param name="fromCurrency">From currency.</param>
        /// <param name="toCurrency">To currency.</param>
        /// <param name="amount">The amount.</param>
        public CurrencyConvertRequest(string fromCurrency, string toCurrency, float amount)
        {
            FromCurrency = fromCurrency;
            ToCurrency = toCurrency;
            Amount = amount;
        }

        /// <summary>
        /// Gets or sets from currency.
        /// </summary>
        /// <value>
        /// From currency.
        /// </value>
        [Required]
        public string FromCurrency { get; }

        /// <summary>
        /// Converts to currency.
        /// </summary>
        /// <value>
        /// To currency.
        /// </value>
        [Required]
        public string ToCurrency { get; }

        /// <summary>
        /// Gets or sets the amount.
        /// </summary>
        /// <value>
        /// The amount.
        /// </value>
        [Required]
        public float Amount { get; }
    }
}
