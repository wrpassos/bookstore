﻿using System;
using System.Collections.Generic;
using ProductService.Models;

namespace ProductService.Persistence
{
    /// <summary>
    /// Define ProductRepository contract 
    /// </summary>
    public interface IProductRepository
    {
        void Add(Product product);
        IEnumerable<Product> GetAll();
        Product GetBy(Guid id);
        void Remove(Guid id);
        void Update(Product product);
    }
}