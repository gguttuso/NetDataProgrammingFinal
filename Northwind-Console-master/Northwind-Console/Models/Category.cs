using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NorthwindConsole.Models
{
    public class Category
    {

        // these are the column names
        // CategoryID
        // CategoryName
        // Description
        public int CategoryId { get; set; }

        // this is a required attribute
        // Required is a class attribute that we can use
        // we are passing in a parameter for the error message
        [Required(ErrorMessage = "Please enter the name")]
        public string CategoryName { get; set; }

        public string Description { get; set; }

        // this is a list of many of products
        // this is showing the one to many relationship
        public virtual List<Product> Products { get; set; }
    }
}
