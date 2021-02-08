using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
        //Buradaki verileri IEntityReposittory'e aktardık sebebi ile veri kalabalığın önüne geçip tek katmandan yönetmek

        List<ProductDetailDto> GetProductDetailDtos();
        
    }
}
