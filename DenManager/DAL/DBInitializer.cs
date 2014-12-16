using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DenManager.DAL
{
    public class DBInitializer : DropCreateDatabaseAlways<ProductsContext>
    {
        protected override void Seed(ProductsContext context)
        {
            base.Seed(context);
            context.Products.Add(new Product((decimal)3.5, string.Empty, "Tyskie"));
            
        }
    }
}