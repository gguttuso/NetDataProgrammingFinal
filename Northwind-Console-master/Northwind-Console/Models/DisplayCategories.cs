using System;
using System.Linq;

namespace NorthwindConsole.Models
{
    public class DisplayCategories
    {
        public void DisplayAllCategories()
        {
            var db = new NorthwindContext();
            var query = db.Categories.OrderBy(p => p.CategoryId);

            Console.WriteLine($"{query.Count()} records returned");
            foreach (var item in query)
            {
                Console.WriteLine($"{item.CategoryId} {item.CategoryName} - {item.Description}");
            }
        }

    }
}
