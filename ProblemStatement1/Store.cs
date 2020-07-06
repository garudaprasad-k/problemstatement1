﻿using System;
using System.Collections.Generic;

namespace ProblemStatement1
{
    public class Store
    {
        private static Store _instance = new Store();
        private List<Product> _products;

        public static Store Instance
        {
            get
            {
                if (_instance == null) _instance = new Store();
                return _instance;
            }
        }

        public List<Product> AllProducts
        {
            get { return _products; }
        }

        private Store()
        {
            _products = new List<Product>();
        }

        public bool AddProductToStore(string productName, decimal price)
        {
            if (productName.Equals(string.Empty) || this.Exists(productName) || price <= 0)
            {
                return false;
            }

            _products.Add(new Product(productName, price));
            return true;
        }

        public void RemoveProductFromStore(Product product)
        {
            if (_products.IndexOf(product) > -1)
            {
                _products.Remove(product);
            }
        }

        private bool Exists(string productname)
        {
            return (this._products.FindIndex(x => x.ProductName.Equals(productname,
                   StringComparison.OrdinalIgnoreCase)) != -1);
        }
    }
}
