using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using NLog;
using NorthwindConsole.Models;

namespace NorthwindConsole
{`
    class MainClass
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public static void Main(string[] args)
        {
            logger.Info("Program started");
            try
            {
                string choice;
                do
                {
                    Menu menu = new Menu();
                    menu.MenuClass();

                    Console.WriteLine("\"q\" to quit");
                    choice = Console.ReadLine();
                    Console.Clear();
                    logger.Info($"Option {choice} selected");


                    // 1. DISPLAY CATEGORIES
                    if (choice == "1")
                    {
                        DisplayCategories dc = new DisplayCategories();
                        dc.DisplayAllCategories();
                    }

                    // 2. ADD CATEGORY
                    else if (choice == "2")
                    {
                        AddCategory ac = new AddCategory();
                        ac.AddCategoryClass();
                    }

                    // 3. DISPLAY CATEGORY AND RELATED PRODUCTS
                    else if (choice == "3")
                    {
                        DisplayCatRelatedProd dc = new DisplayCatRelatedProd();
                        dc.DisplayCatRelatedProdClass();
                    }

                    // 4. DISPLAY ALL CATEGORIES AND THEIR RELATED PRODUCTS
                    else if (choice == "4")
                    {
                        DisplayAllCatRelatedProd dac = new DisplayAllCatRelatedProd();
                        dac.DisplayAllCatRelatedProdClass();
                    }

                    // 5. EDIT CATEGORY NAME
                    else if (choice == "5")
                    {
                        EditCatName ecn = new EditCatName();
                        ecn.EditCatNameClass();
                    }

                    // 6. DELETE CATEGORY
                    else if (choice == "6")
                    {
                        DeleteCategory dc = new DeleteCategory();
                        dc.DeleteCategoryClass();
                    }

                    // 7. DISPLAY PRODUCTS
                    else if (choice == "7")
                    {
                        DisplayProducts dp = new DisplayProducts();
                        dp.DisplayProductsClass();
                    }

                    // 8. ADD PRODUCT
                    else if (choice == "8")
                    {
                        AddProduct ap = new AddProduct();
                        ap.AddProductClass();
                    }

                    // 9. DISPLAY A SPECIFIC PRODUCT
                    else if (choice == "9")
                    {
                        DisplaySpecificProduct dsp = new DisplaySpecificProduct();
                        dsp.DisplaySpecificProductClass();
                    }

                    // 10. EDIT PRODUCT
                    else if (choice == "10")
                    {
                        EditProduct ep = new EditProduct();
                        ep.EditProductClass();
                    }

                    // DELETE PRODUCT
                    else if (choice == "11")
                    {
                        DeleteProduct dp = new DeleteProduct();
                        dp.DeleteProductClass();
                    }

                    Console.WriteLine();

                } while (choice.ToLower() != "q");
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
            }
            logger.Info("Program ended");
        }
    }
}
