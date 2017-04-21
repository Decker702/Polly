using Polly.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Polly.DAL
{
    public class PollyInitalizer : System.Data.Entity.DropCreateDatabaseIfModelChanges<PollyContext>
    {
        protected override void Seed(PollyContext context)
        {

            var customers = new List<Customer>
            {
            new Customer{FirstName="Carson",LastName="Alexander",PurchaseDate=DateTime.Parse("2005-09-01")},
            new Customer{FirstName="Meredith",LastName="Alonso",PurchaseDate=DateTime.Parse("2002-09-01")},
            new Customer{FirstName="Arturo",LastName="Anand",PurchaseDate=DateTime.Parse("2003-09-01")},
            new Customer{FirstName="Gytis",LastName="Barzdukas",PurchaseDate=DateTime.Parse("2002-09-01")},
            new Customer{FirstName="Yan",LastName="Li",PurchaseDate=DateTime.Parse("2002-09-01")},
            new Customer{FirstName="Peggy",LastName="Justice",PurchaseDate=DateTime.Parse("2001-09-01")},
            new Customer{FirstName="Laura",LastName="Norman",PurchaseDate=DateTime.Parse("2003-09-01")},
            new Customer{FirstName="Nino",LastName="Olivetto",PurchaseDate=DateTime.Parse("2005-09-01")}
            };

            customers.ForEach(c => context.Customers.Add(c));
            context.SaveChanges();

            var products = new List<Product>
            {
            new Product{ProductID=1050,ProductName="Roses", UPC=2343, Inventory=6, Price=4.87M },
            new Product{ProductID=4022,ProductName="Insecticide", UPC=3345, Inventory=45, Price=3.99M},
            new Product{ProductID=3141,ProductName="Mulch", UPC=3345, Inventory=5, Price=8.99M},
            };

            products.ForEach(s => context.Products.Add(s));
            context.SaveChanges();

            var purchases = new List<Purchase>
            {
            new Purchase{CustomerID=1,ProductID=1050},
            new Purchase{CustomerID=1,ProductID=4022},
            new Purchase{CustomerID=7,ProductID=3141},
            };

            purchases.ForEach(s => context.Purchases.Add(s));
            context.SaveChanges();
        }

    }
    }
