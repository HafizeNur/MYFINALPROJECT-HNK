using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    //interface kendisi değil metotları default publictir.
    public interface IProductDal:IEntityRepository<Product>
    {
       
    }
}
