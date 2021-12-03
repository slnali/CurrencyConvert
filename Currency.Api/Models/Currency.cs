using System;
using System.ComponentModel.DataAnnotations;

namespace Currency.Api.Models
{
    //POC: Card details class and user details should have nested classes here - improved
    /// <summary>
    /// Payment Model used to store data in database
    /// </summary>
    public class Currency
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Currency"/> class.
        /// </summary>
        public Currency()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Currency"/> class.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="symbol">The symbol.</param>
        /// <param name="name">The name.</param>
        public Currency(int id, string symbol, string name)
        {
            this.Id = id;
            this.Symbol = symbol;
            this.Name = name;
        }

        /// <summary>
        /// Gets or sets the currency identifier.
        /// </summary>
        /// <value>
        /// The payment identifier.
        /// </value>
        [Required]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the currency symbol.
        /// </summary>
        /// <value>
        /// The payment identifier.
        /// </value>
        [Required]
        public string Symbol { get; }

        /// <summary>
        /// Gets or sets the currency name/description.
        /// </summary>
        /// <value>
        /// The payment identifier.
        /// </value>
        [Required]
        public string Name { get; }
    }
}
