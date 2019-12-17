using System;
using System.Linq;

namespace NorthwindConsole.Models
{
    public class EditProduct
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        public void EditProductClass()
        {
            // get the product
            var db = new NorthwindContext();
            var query = db.Products.OrderBy(p => p.ProductID);

            // ask user to select existing category
            Console.WriteLine("Which product do you want to edit?");
            foreach (var item in query)
            {
                Console.WriteLine($"{item.ProductID}) {item.ProductName}");
            }
            int id = int.Parse(Console.ReadLine());
            Console.Clear();
            logger.Info($"ProductID {id} selected");

            // get category from the database
            Product product = db.Products.FirstOrDefault(p => p.ProductID == id);

            // ask the user what they want to edit
            Console.WriteLine("1. Product Name" + "\n" +
                "2. Quantity Per Unit" + "\n" +
                "3. Unit Price" + "\n" +
                "4. Units in Stock" + "\n" +
                "5. Units on Order" + "\n" +
                "6. Reorder Level" + "\n");
            var input = int.Parse(Console.ReadLine());

            // update product name
            if (input == 1)
            {

                // ask user to provide udpated name
                Console.WriteLine("Enter the new product name:");
                var newName = Console.ReadLine();
                logger.Info($"User entered {newName}");

                // update category in database
                product.ProductName = newName;
                db.SaveChanges();

            }

            // update quantity per unit
            else if (input == 2)
            {

                // ask user to provide udpated name
                Console.WriteLine("Enter the new quantity per unit:");
                var newQuanPerUnit = Console.ReadLine();
                logger.Info($"User entered {newQuanPerUnit}");

                // update category in database
                product.QuantityPerUnit = newQuanPerUnit;
                db.SaveChanges();

            }

            // update unit price
            else if (input == 3)
            {

                // ask user to provide udpated name
                Console.WriteLine("Enter the new unit price:");
                var newUnitPrice = Decimal.Parse(Console.ReadLine());
                logger.Info($"User entered {newUnitPrice}");

                // update category in database
                product.UnitPrice = newUnitPrice;
                db.SaveChanges();

            }

            // update units in stock
            else if (input == 4)
            {

                // ask user to provide udpated name
                Console.WriteLine("Enter the new units in stock:");
                var newUnitsStock = Int16.Parse(Console.ReadLine());
                logger.Info($"User entered {newUnitsStock}");

                // update category in database
                product.UnitsInStock = newUnitsStock;
                db.SaveChanges();

            }

            // update units in stock
            else if (input == 5)
            {

                // ask user to provide udpated name
                Console.WriteLine("Enter the new units on order:");
                var newUnitsOnOrder = Int16.Parse(Console.ReadLine());
                logger.Info($"User entered {newUnitsOnOrder}");

                // update category in database
                product.UnitsOnOrder = newUnitsOnOrder;
                db.SaveChanges();

            }

            // update units in stock
            else if (input == 6)
            {

                // ask user to provide udpated name
                Console.WriteLine("Enter the new reorder level:");
                var newReorderLevel = Int16.Parse(Console.ReadLine());
                logger.Info($"User entered {newReorderLevel}");

                // update category in database
                product.ReorderLevel = newReorderLevel;
                db.SaveChanges();

            }
        }
    }
}
