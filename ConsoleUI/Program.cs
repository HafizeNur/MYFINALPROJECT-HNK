using Business.Concreate;
using DataAccess.Concreate.EntityFramework;
using DataAccess.Concreate.InMemory;
using System;

namespace ConsoleUI
{
    //SOLID
    //O:Yaptığın siteme yeni bir kod ekliyorsan mevcut sisteme dokunamazsın.
    class Program
    {
        static void Main(string[] args)
        {
            //CategoryTest();
            //IoC
             ProductTest();


        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

            Console.WriteLine("Tüm Kategoriler");
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            Console.WriteLine("Ürün Detayları");
            foreach (var product in productManager.GetProductDetails())
            {
                Console.WriteLine(product.ProductName + "/" + product.CategoryName);
            }

            ////Console.WriteLine("Tüm Ürünler");
            ////foreach (var product in productManager.GetAll())
            ////{
            ////    Console.WriteLine(product.ProductName);
            ////}

            ////Console.WriteLine("CategoryId=2 olan Ürünler");
            ////foreach (var product in productManager.GetAllByCategoryId(2))
            ////{
            ////    Console.WriteLine(product.ProductName);
            ////}

            ////Console.WriteLine("Fiyatı 40 ile 100 arasında olan Ürünler");
            ////foreach (var product in productManager.GetByUnitPrice(40, 100))
            ////{
            ////    Console.WriteLine(product.ProductName);
            /////}

            //ProductManager productManager = new ProductManager(new InMemoryProductDal());
            //foreach (var product in productManager.GetAll())
            //{
            //    Console.WriteLine(product.ProductName);
            //}
        }
    }
}
