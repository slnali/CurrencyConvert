namespace Currency.Contract.DTO
{
    /// <summary>
    /// CurrencyDto.
    /// </summary>
    public class CurrencyDto
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CurrencyDto"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="symbol">The symbol.</param>
        public CurrencyDto(string name, string symbol)
        {
            this.Name = name;
            this.Symbol = symbol;
        }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; }

        /// <summary>
        /// Gets or sets the symbol.
        /// </summary>
        /// <value>
        /// The symbol.
        /// </value>
        public string Symbol { get; }
    }

}
