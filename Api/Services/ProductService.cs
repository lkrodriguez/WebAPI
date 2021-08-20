using System;
using System.ComponentModel;
using System.Collections.Generic;

using Api.Models;

namespace Api.Services
{
    public class ProductService
    {
        List<Products> _producstList = null;

        public ProductService()
        {
            _producstList = new List<Products>();    
        }

        public List<Products> GetProducts()
        {
            return _producstList;
        }

        public void AddProduct(Products products)
        {
            _producstList.Add(products);
        }
    }
}