﻿using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concreate.InMemory;
using Entities.Concreate;
using Entities.DTOs;
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

        public List<Product> GetAllByCategoryId(int id)
        {
            return _productDal.GetAll(p => p.CategoryId == id);
        }

        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            return _productDal.GetAll(p => p.UnitPrice <= min && p.UnitPrice <= max);
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            return _productDal.GetProductDetails();
        }
    }
}
