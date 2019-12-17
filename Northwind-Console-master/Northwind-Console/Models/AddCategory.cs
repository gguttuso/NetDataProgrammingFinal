using System;
namespace NorthwindConsole.Models
{
    public class AddCategory
    {
        public void AddCategoryClass()
        {
            Category category = new Category();
            Console.WriteLine("Enter Category Name:");
            category.CategoryName = Console.ReadLine();
            Console.WriteLine("Enter the Category Description:");
            category.Description = Console.ReadLine();

            var db = new NorthwindContext();
            db.Categories.Add(category);
            db.SaveChanges();
        }
    }
}
