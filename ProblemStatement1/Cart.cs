using System;
using System.Collections.Generic;

namespace ProblemStatement1
{
    class Cart
    {
        private List<Purchase> _purchases;

        public List<Purchase> AllPurchases
        {
            get { return _purchases; }
        }

        public Cart()
        {
            _purchases = new List<Purchase>();
        }

        private void DataChangeHandler()
        {
           
        }

        public void AddProductToCart(string productName, int units)
        {
            if (Store.Instance().AllProducts.Count > 0 && units != 0)
            {
                Purchase purchase = _purchases.Find(u => u.ProductName.ToLower().Equals(productName.ToLower()));
                if(purchase == null)
                {
                    _purchases.Add(new Purchase(Store.Instance().AllProducts.Find(u => u.ProductName.ToLower().Equals(productName.ToLower())), units));
                }
                else
                {
                    purchase.Quantity += units;
                }
            }
        }


        public void RemovePurchaseFromCart(Purchase purchase)
        {
            _purchases.Remove(purchase);
        }

        public void ClearPurchases()
        {
            _purchases.Clear();
        }
    }
}
