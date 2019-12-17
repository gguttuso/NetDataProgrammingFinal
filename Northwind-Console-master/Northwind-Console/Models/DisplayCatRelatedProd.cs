using System;
using System.Linq;
namespace NorthwindConsole.Models

{
    public class DisplayCatRelatedProd
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public void DisplayCatRelatedProdClass()
        {
            var db = new NorthwindContext();

            var query = db.Categories.OrderBy(p => p.CategoryId);

            Console.WriteLine("Select the category whose products you want to display:");
            foreach (var item in query)
            {
                Console.WriteLine($"{item.CategoryId}) {item.CategoryName}");
            }
            int id = int.Parse(Console.ReadLine());
            Console.Clear();
            logger.Info($"CategoryId {id} selected");
            Category category = db.Categories.FirstOrDefault(c => c.CategoryId == id);
            Console.WriteLine($"{category.CategoryName} - {category.Description}");
            foreach (Product p in category.Products)
            {
                Console.WriteLine(p.ProductName);
            }
        }
    }
}
