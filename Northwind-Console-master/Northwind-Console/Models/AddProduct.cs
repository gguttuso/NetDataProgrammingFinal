using System;
using System.Linq;

namespace NorthwindConsole.Models
{
    public class AddProduct
    {
        public void AddProductClass()
        {
            Product product = new Product();
            Console.WriteLine("Enter Product Name:");
            product.ProductName = Console.ReadLine();
            Console.WriteLine("Enter the Category:");
            var db = new NorthwindContext();
            var query = db.Categories.OrderBy(p => p.CategoryId);

            Console.WriteLine($"{query.Count()} records returned");
            foreach (var item in query)
            {
                Console.WriteLine($"{item.CategoryId} {item.CategoryName} - {item.Description}");
            }
            product.CategoryId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Quantity Per Unit:");
            product.QuantityPerUnit = Console.ReadLine();
            Console.WriteLine("Enter the Unit Price:");
            product.UnitPrice = Decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Units in Stock:");
            product.UnitsInStock = Int16.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Units on Order:");
            product.UnitsOnOrder = Int16.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Reorder Level:");
            product.ReorderLevel = Int16.Parse(Console.ReadLine());
            Console.WriteLine("Discontinued? True or False:");
            Boolean discontinued = bool.Parse(Console.ReadLine());
            if (discontinued)
            {
                product.Discontinued = true;
            }
            else
            {

                product.Discontinued = false;
            }

            //var db = new NorthwindContext();
            db.Products.Add(product);
            db.SaveChanges();
        }
    }
}
