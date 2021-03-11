using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]  // İnsanlar bana soldaki yazdığım gibi ulaşsın demektir.
    [ApiController]   //Bu kısma Attribute denilmektedir. Bir class ile ilgili bilgi verme ve imzalama içerir. Burası Controllerdir demedktir.
    public class ProductsController : ControllerBase   // Controlbase den interit edilmektedir.
    {
        //naming convention = isimlendirme standartı = _pvb şeklinde vermek
        //Loosely coupled = Gevşek Bağlılık : Bağımlı ama soyuta bağlı Manegare bağlı
        // IoC Container =  Değişimin Kontrolü (Inversion of Control)
        
        IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet ("GetAll")]
        public IActionResult GetAll() 
        {
            //Swagger = Test ortmı
            // Dependency Chain = Sistem bağımlılığı  / Bağımlılık zinciri
            // Burada bir bağımlılık vardır. Servis Manegare bağımlıdır. Idal EfDala bağımlı
            //IProductService productService = new ProductManager(new EfProductDal());

            Thread.Sleep(1000);
            var result = _productService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpGet ("GetById")]
        public IActionResult GetById(int id)
        {
            var result = _productService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost ("Add")]
        public IActionResult Add(Product product) 
        {
            var result = _productService.Add(product);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        
        }
        
        
    }
}
