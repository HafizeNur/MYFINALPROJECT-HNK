using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    //generic constrait 
    //class:referans tip olabilir demek.class olabilir demek değil.
    //IEntity veya IEntityden türeyen birsey olması için , den sonra IEntity ekliyoruz.
    //Ama ben IEntity olmasın istiyorum.
    //Sistemimiz veritabanı nesneleriyle çalışan bir hale geldi.
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        //filtre vermek zorunda değilsin.Tüm ürünleri listeler.
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        //filtre vermek zorundasın.Tek bir ürünü filtreler bir şeye göre.
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
       // List<T> GetAllByCategory(int categoryId);//Bunu iptal ettik.
    }
}
