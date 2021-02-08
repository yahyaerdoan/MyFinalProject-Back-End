using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    // generic constraint (kıstlama yapmak)
    // class :referans tip
    // IEntity : IEntity olabilir veya IEntity implemente eden bir nesne olabilir.

    public interface IEntityRepository<T> where T : class, IEntity, new() 
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null); // Burada ise istediğim filtreye göre getirir.
        T Get(Expression<Func<T, bool>> filter); // Ürün hakkında detaylı veri gösterir 

        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);



        //Expression metodu veri filitrelemeyi sağlar dolayısıyla aşağıdaki categori metoduna ihtiyacımız kalmaz
        /*List<T> GetAllByCategory(int categoryId);   */// Ürünleri Kategoriye göre sıralamamızı sağlar

    }
}
