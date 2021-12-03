using System.ComponentModel.DataAnnotations;

namespace Currency.Contract.Responses
{
    /// <summary>
    /// CurrencyConvertResult.
    /// </summary>
    public class CurrencyConvertResult
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="CurrencyConvertResult" /> class.
        /// </summary>
        /// <param name="result">The result.</param>
        /// <param name="rate">The rate.</param>
        public CurrencyConvertResult(float result, float rate)
        {
            Result = result;
            Rate = rate;
        }

        /// <summary>
        /// Gets or sets from currency.
        /// </summary>
        /// <value>
        /// From currency.
        /// </value>
        [Required]
        public float Result { get; }

        /// <summary>
        /// Converts to currency.
        /// </summary>
        /// <value>
        /// To currency.
        /// </value>
        [Required]
        public float Rate { get; }
    }
}
