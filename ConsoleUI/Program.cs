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
            //CategoryTest();



        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName + "  " + category.CategoryId);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var product in productManager.GetProductDetailDtos())
            {
                Console.WriteLine("\n" + product.ProductId + " - " + product.ProductName + " - " + product.CategoryName + "\n");
            }
        }

        private static void LinqMetod()
        {
            ProductManager productManager2 = new ProductManager(new EfProductDal());
            foreach (var product in productManager2.GetAllByCategoryId(7))
            {
                Console.WriteLine(product.ProductId + " -- " + product.ProductName);
            }
        }

        private static void InMemoryOrnek()
        {
            ProductManager productManager1 = new ProductManager(new InMemoryProductDal());
            foreach (var product in productManager1.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}
