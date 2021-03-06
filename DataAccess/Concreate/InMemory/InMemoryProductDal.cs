﻿using DataAccess.Abstract;
using Entities.Concreate;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concreate.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            //Oracle,Sql Server,MongoDb vsden geliyormus gibi simule ediyor.
            //_products = new List<Product>
            //{
            //    new Product{ProductId=1, CategoryId=1, ProductName="Bardak",UnitPrice=15,UnitInStock=15},
            //    new Product{ProductId=2, CategoryId=1, ProductName="Kamera",UnitPrice=500,UnitInStock=3},
            //    new Product{ProductId=3, CategoryId=2, ProductName="Telefon",UnitPrice=1500,UnitInStock=2},
            //    new Product{ProductId=4, CategoryId=2, ProductName="Klavye",UnitPrice=150,UnitInStock=65},
            //    new Product{ProductId=5, CategoryId=2, ProductName="Fare",UnitPrice=85,UnitInStock=1},

            //};
        }

        public void Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }

        //GENERIC INTERFACE YAPISINI KULLANMADAN ÖNCE YAZDIĞIM KODLAR 
        //public void Add(Product product)
        //{
        //    _products.Add(product);
        //}

        //public void Delete(Product product)
        //{
        //    //LINQ-Language Integrated Query bilmiyo olsaydık.Yazmamız gereken kod aşağıdaki gibiydi.Tek tek dolasmamız lazımdı.
        //    //Product productToDelete;

        //    //foreach (var p in _products)
        //    //{
        //    //    if (product.ProductId==p.ProductId)
        //    //    {
        //    //        productToDelete = p;
        //    //    }
        //    //}

        //    //LINQ bildiğimiz için.Aşağıdaki gibi yaparız.
        //    //Id bazlı yapılarda singleordefault kullanırız.
        //    Product productToDelete = _products.SingleOrDefault(p=>p.ProductId==product.ProductId);
        //    _products.Remove(productToDelete);//silmeişlemi artık güvenli olur.
        //    // _products.Remove(product);//Böyle tek başına yazınca listeden asla silinmez.Referans numaraları farklı olduğu için.
        //}

        //public List<Product> GetAll()
        //{
        //    return _products;
        //}

        //public List<Product> GetAllByCategory(int categoryId)
        //{
        //   return  _products.Where(p=>p.CategoryId==categoryId).ToList();
        //}

        //public void Update(Product product)
        //{
        //    //Gönderdiğim ürün IDsine sahip olan listedeki ürünü bul demek.
        //    Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
        //    productToUpdate.ProductName = product.ProductName;
        //    productToUpdate.CategoryId = product.CategoryId;
        //    productToUpdate.UnitInStock = product.UnitInStock;
        //    productToUpdate.UnitPrice = product.UnitPrice;
        //}
    }
}
