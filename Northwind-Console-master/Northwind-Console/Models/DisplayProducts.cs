using System;
using System.Linq;

namespace NorthwindConsole.Models
{
    public class DisplayProducts
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public void DisplayProductsClass()
        {
            string choice;

            Console.WriteLine("1) Display All Products");
            Console.WriteLine("2) Display Discontinued Products");
            Console.WriteLine("3) Display Active Products");

            choice = Console.ReadLine();
            Console.Clear();
            logger.Info($"Option {choice} selected");

            // display all products
            if (choice == "1")
            {
                var db = new NorthwindContext();
                var query = db.Products.OrderBy(p => p.ProductID);

                Console.WriteLine($"{query.Count()} records returned");
                foreach (var item in query)
                {
                    Console.WriteLine($"{item.ProductID} {item.ProductName}");
                }
            }

            // display discontinued products
            // in the database, "discontinued" is stored as a boolean
            else if (choice == "2")
            {
                var db = new NorthwindContext();
                var query = db.Products.Where(p => p.Discontinued == true);

                Console.WriteLine($"{query.Count()} records returned");
                foreach (var item in query)
                {
                    Console.WriteLine($"{item.ProductID} {item.ProductName}");
                }
            }

            // display active products
            // in the database, "discontinued" is stored as a boolean
            else if (choice == "3")
            {
                var db = new NorthwindContext();
                var query = db.Products.Where(p => p.Discontinued == false);

                Console.WriteLine($"{query.Count()} records returned");
                foreach (var item in query)
                {
                    Console.WriteLine($"{item.ProductID} {item.ProductName}");
                }
            }
        }
    }
}
