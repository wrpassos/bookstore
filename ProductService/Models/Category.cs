﻿using System;
using System.Collections.Generic;

namespace ProductService.Models
{
    /// <summary>
    /// POCO class to define the Category
    /// </summary>
    public class Category
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public IEnumerable<Product> Products { get; set; }

        public Category()
        {
            Products = new List<Product>();
        }
    }
}