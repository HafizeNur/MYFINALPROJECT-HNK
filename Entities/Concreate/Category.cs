﻿using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concreate
{
    //Çıplak class kalmasın
    public class Category : IEntity
    {
        public string CategoryName { get; set; }
        public int CategoryId { get; set; }
    }
}
