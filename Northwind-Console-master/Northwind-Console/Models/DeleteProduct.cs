using System;
using System.Linq;

namespace NorthwindConsole.Models
{
    public class DeleteProduct
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        public void DeleteProductClass()
        {
            // get the product
            var db = new NorthwindContext();
            var query = db.Products.OrderBy(p => p.ProductID);

            // ask user which product
            Console.WriteLine("Which product do you want to delete?");
            foreach (var item in query)
            {
                Console.WriteLine($"{item.ProductID}) {item.ProductName}");
            }
            int id = int.Parse(Console.ReadLine());
            Console.Clear();
            logger.Info($"ProductID {id} selected");

            // get category from the database
            Product product = db.Products.FirstOrDefault(p => p.ProductID == id);

            // delete category in database
            db.Products.Remove(product);
            db.SaveChanges();
        }
    }
}
