using System;
using System.Linq;

namespace NorthwindConsole.Models
{
    public class DeleteCategory
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public void DeleteCategoryClass()
        {
            // get the category!
            var db = new NorthwindContext();
            var query = db.Categories.OrderBy(p => p.CategoryId);

            // ask user to select existing category
            Console.WriteLine("Select existing category:");
            foreach (var item in query)
            {
                Console.WriteLine($"{item.CategoryId}) {item.CategoryName}");
            }
            int id = int.Parse(Console.ReadLine());
            Console.Clear();
            logger.Info($"CategoryId {id} selected");

            // get category from the database
            Category category = db.Categories.FirstOrDefault(c => c.CategoryId == id);

            // delete category in database
            db.Categories.Remove(category);
            db.SaveChanges();
        }
    }
}
