using System;
using System.Collections.Generic;

namespace ProblemStatement1
{
    public class Store
    {      
        private static Store _instance = new Store();

        public static Store Instance()
        {
            return _instance;
        }

        private List<Product> _products;

        public List<Product> AllProducts
        {
            get { return _products; }
        }

        private Store()
        {
            _products = new List<Product>();
            this.addProductToStore("A", 50);
            this.addProductToStore("B", 30);
            this.addProductToStore("C", 20);
            this.addProductToStore("D", 15);
        }


        public bool addProductToStore(string productName, decimal price)
        {
            if (productName.Equals(string.Empty) || this.exists(productName) || price <= 0)
            {
                return false;
            }

            _products.Add(new Product(productName, price));
            return true;
        }

        public void RemoveProductFromStore(Product product)
        {
            _products.Remove(product);
        }

        public bool exists(string productname)
        {
            return (this._products.FindIndex(x => x.ProductName.Equals(productname,
                   StringComparison.OrdinalIgnoreCase)) != -1);
        }
    }
}
