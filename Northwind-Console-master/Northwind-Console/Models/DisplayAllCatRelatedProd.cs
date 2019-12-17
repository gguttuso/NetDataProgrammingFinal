using System;
using System.Linq;

namespace NorthwindConsole.Models
{
    public class DisplayAllCatRelatedProd
    {
        public void DisplayAllCatRelatedProdClass()
        {

            var db = new NorthwindContext();
            var query = db.Categories.Include("Products").OrderBy(p => p.CategoryId);
            foreach (var item in query)
            {
                Console.WriteLine($"{item.CategoryName}");
                foreach (Product p in item.Products)
                {
                    Console.WriteLine($"\t{p.ProductName}");
                }
            }
        }
    }
}
