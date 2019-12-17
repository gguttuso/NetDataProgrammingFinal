using System;
using System.Linq;

namespace NorthwindConsole.Models
{
    public class DisplaySpecificProduct
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public void DisplaySpecificProductClass()
        {
            // display all products to choose from
            var db = new NorthwindContext();
            var query = db.Products.OrderBy(p => p.ProductID);

            Console.WriteLine($"{query.Count()} records returned");
            foreach (var item in query)
            {
                Console.WriteLine($"{item.ProductID} {item.ProductName}");
            }

            Console.WriteLine("Which product ID?");
            int id = int.Parse(Console.ReadLine());
            Console.Clear();
            logger.Info($"Product {id} selected");
            Product product = db.Products.FirstOrDefault(p => p.ProductID == id);
            Console.WriteLine($"Name: {product.ProductName}" + "\n" +
                $"Category: {product.QuantityPerUnit}" + "\n" +
                $"Quantity Per Unit: {product.QuantityPerUnit}" + "\n" +
                $"Reorder Level: {product.ReorderLevel} " + "\n" +
                $"Unit Price: {product.UnitPrice}" + "\n" +
                $"Units in Stock: {product.UnitsInStock} " + "\n" +
                $"Units on Order: {product.UnitsOnOrder}" + "\n" +
                $"Discontinued: {product.Discontinued} ");
            //foreach (Product p in category.Products)
            //{
            //    Console.WriteLine(p.ProductName);
            //}
        }
    }
}
