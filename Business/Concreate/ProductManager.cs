using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concreate.InMemory;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concreate
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {

            //InMemoryProductDal inMemoryProductDal = new InMemoryProductDal();//Böyle yaparsak veri tabanı değişince tüm kodları değiştirmemiz gerekir.Kuralımız neydi?bir iş katmanı başka sınıfları newlemez.
            //İş kodları
            //Yetkisi var mı ?
            return _productDal.GetAll();
        }
    }
}
