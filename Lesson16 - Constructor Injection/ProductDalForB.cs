﻿using System;

namespace Lesson16___Constructor_Injection
{
    class ProductDalForB : IProductDal
    {
        public void Add()
        {
            Console.WriteLine("Product Added For B");
        }
        public void Delete()
        {
            Console.WriteLine("Product Deleted For B");
        }
    }
}