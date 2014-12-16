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
            context.Beers.Add(new Beer
                                 {
                                     Bottle = (decimal)0.35,
                                     Name = "Tyskie",
                                     Price = (decimal)3,
                                 });
            context.Cigarettes.Add(new Cigarettes
            {
                Type = "Light",
                Name = "LM",
                Price = (decimal)13,
            });

            context.Debters.Add(new Debtor
                                {
                                    Debt = 200,
                                    Name = "WACO"
                                });

        }
    }
}