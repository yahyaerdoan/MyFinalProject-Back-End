using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;


namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product>
            {
                new Product{ProductId = 1, CategoryId = 1, ProductName ="Kitap", UnitPrice = 15, UnitsInStock =15},
                new Product{ProductId = 2, CategoryId = 1, ProductName ="Defter", UnitPrice = 500, UnitsInStock =3},
                new Product{ProductId = 3, CategoryId = 2, ProductName ="Cüdan", UnitPrice = 1500, UnitsInStock =2},
                new Product{ProductId = 4, CategoryId = 2, ProductName ="Kamera", UnitPrice = 150, UnitsInStock =65},
                new Product{ProductId = 5, CategoryId = 2, ProductName ="Saat", UnitPrice = 85, UnitsInStock =1},

            };
           
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product productToDelete = null;
            foreach (var p in _products)
            {
                if (product.ProductId == p.ProductId)
                {
                    productToDelete = p;
                }
            }    // LINQ => Language Integrated Query : Aşağıdaki linq metodu veri dolarak silme işlemini yapar. Yukarıdaki Foreach yapısının kolay metodudur. 
            productToDelete = _products.SingleOrDefault(p=>p.ProductId == product.ProductId);
            _products.Remove(productToDelete);
        }

        public List<Product> GetAll()
        {
            return _products;
        }

                                                // Gönderdiğm ürün ıdsine  sahip olan listedeki ürünü bul
        public void Update(Product product)   // Ürün hakkında tüm bilgiler güncellenmiş oldu. 
        {
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
            productToUpdate.CategoryId = product.CategoryId;
        }

        public List<Product> GetAllByCategory(int categoryId) // Ürünleri Kategoriye göre sıralamamızı sağlar  
        {
            return  _products.Where(p => p.CategoryId == categoryId).ToList();
            
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<ProductDetailDto> GetProductDetailDtos()
        {
            throw new NotImplementedException();
        }
    }

}
