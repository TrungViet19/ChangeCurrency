using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CurrencyChange.Models
{
    public class CurrencyChangeContext : DbContext
    {
        public CurrencyChangeContext(DbContextOptions<CurrencyChangeContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Currency>().HasData(
                new Currency() { Id = 1, Ten = "USA", Tygia = 23260 },
                new Currency() { Id = 2, Ten = "EUR", Tygia = 27060 },
                new Currency() { Id = 3, Ten = "AUD", Tygia = 16798 },
                new Currency() { Id = 4, Ten = "JPY", Tygia = 20704 }
            );
        }

        public DbSet<CurrencyChange.Models.Currency> Currency { get; set; }
    }
}
