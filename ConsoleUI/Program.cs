using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductTest();
            //LinqMetod();
            //InMemoryOrnek();
            CategoryTest();



        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll().Data)
            {
                Console.WriteLine(category.CategoryName + "  " + category.CategoryId);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal(), new CategoryManager(new EfCategoryDal()));

            var result = productManager.GetProductDetailDtos();
            if (result.Success == true)
            {
                foreach (var product in result.Data)
                {
                    Console.WriteLine("\n" + product.ProductId + " - " + product.ProductName + " - " + product.CategoryName + "\n");

                }

            }
            else
            {
                Console.WriteLine(result.Message);
            }

            
        }

        private static void LinqMetod()
        {
            ProductManager productManager2 = new ProductManager(new EfProductDal(), new CategoryManager(new EfCategoryDal()));
            foreach (var product in productManager2.GetAllByCategoryId(7).Data)
            {
                Console.WriteLine(product.ProductId + " -- " + product.ProductName);
            }
        }

        private static void InMemoryOrnek()
        {
            ProductManager productManager1 = new ProductManager(new InMemoryProductDal(), new CategoryManager(new EfCategoryDal()));
            foreach (var product in productManager1.GetAll().Data)
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}
