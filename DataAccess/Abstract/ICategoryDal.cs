using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICategoryDal : IEntityRepository<Category>
    {
       
        
        
        //List<Product> GetAll();    // Burada IEntityRepository iplementi olduğu için aşağıdaki verileri zaten IEntityRepository de kullandık böylelikle veri kalabalığı önlendi
                                        //IEntityRepository<Category> verisini vaydığımızda hangi katmanda çalışacağını bilmiş olur.

        //void Add(Product product);

        //void Update(Product product);

        //void Delete(Product product);

        //List<Product> GetAllByCategory(int categoryId);   // Ürünleri Kategoriye göre sıralamamızı sağlar

    }
}
