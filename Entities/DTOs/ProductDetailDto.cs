using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class ProductDetailDto : IDto
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string CategoryName { get; set; }
        public short UnitsInStock { get; set; }

    }
}
//Dto: Data Transformation Object (Veri Dönüştürme Nesnesi) temel amacı veri tabanı ile bağ kurup verileri işleyebilmemize olanak sağlar.
//Entities Katmanında bulunan DTO'nun adı (Nesne)DetailDto dur. DataBaseContext'ten verileri çekip birleştirip yönetebilmek için Join işlemine ihtiyaç duyarız. Ortak verilerimizede  (Nesne)DetailDto Classı üzerinden erişebiliriz.
//Core katmanı Entitien klasöründe bulunan IDto ise IEntity gibi gibi İmplemente eden interface classtır. Evrensellik kazandırır.