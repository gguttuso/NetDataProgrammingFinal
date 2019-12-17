using System;
using System.Linq;

namespace NorthwindConsole.Models
{
    public class EditCatName
    {

        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public void EditCatNameClass()
        {

            // get the category!
            var db = new NorthwindContext();
            var query = db.Categories.OrderBy(p => p.CategoryId);

            // ask user to select existing category
            Console.WriteLine("Select the category whose products you want to display:");
            foreach (var item in query)
            {
                Console.WriteLine($"{item.CategoryId}) {item.CategoryName}");
            }
            int id = int.Parse(Console.ReadLine());
            Console.Clear();
            logger.Info($"CategoryId {id} selected");

            // get category from the database
            Category category = db.Categories.FirstOrDefault(c => c.CategoryId == id);

            // ask user to provide udpated name
            Console.WriteLine("Enter the new category name:");
            var newName = Console.ReadLine();
            logger.Info($"User entered {newName}");

            // update category in database
            category.CategoryName = newName;
            db.SaveChanges();
        }
    }
}
