using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DenManager.DAL
{
    public class ProductsContext: DbContext
    {
        public ProductsContext()
            : base("DefaultConnection")
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Beer> Beers { get; set; }
        public DbSet<Cigarettes> Cigarettes{ get; set; }
        public DbSet<Vodka> Vodkas { get; set; }
        public DbSet<Debtor> Debters { get; set; }
    }
}