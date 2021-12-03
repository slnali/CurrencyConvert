using Currency.Api.StubData;
using Microsoft.EntityFrameworkCore;

namespace Currency.Api.Models
{
    /// <summary>
    /// Class for managing Currency DB Context
    /// </summary>
    /// <seealso cref="DbContext" />
    public class CurrencyContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CurrencyContext"/> class.
        /// </summary>
        /// <param name="options">The options.</param>
        public CurrencyContext(DbContextOptions<CurrencyContext> options)
            : base(options)
        {
        }



        /// <summary>
        /// Gets or sets the currencies table. 
        /// </summary>
        /// <value>
        /// The currencies.
        /// </value>
        public DbSet<Models.Currency> Currencies { get; }

    }
}
