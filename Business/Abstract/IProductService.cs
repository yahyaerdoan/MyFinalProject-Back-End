using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        IDataResult<List<Product>> GetAll(); // hem data hem işlem sonucu hem mesaj hem de list of product içeriği döndürecek
        IDataResult<List<Product>> GetAllByCategoryId(int id);
        IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max);
        IDataResult<List<ProductDetailDto>> GetProductDetailDtos();
        IDataResult<Product> GetById(int productId); //Ürün detayına ait bilgileri getirir.
        IResult Add(Product product); // IResult'ı voidler için yazdık burda döndürme işlemi yok DATA OLMADIĞI İÇİN 
        IResult Update(Product product);


    }
}
