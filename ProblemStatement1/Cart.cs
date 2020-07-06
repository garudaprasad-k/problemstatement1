using System.Collections.Generic;

namespace ProblemStatement1
{
    public class Cart
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

        public void AddPurchaseToCart(string productName, int units)
        {
            if (Store.Instance.AllProducts.Count > 0 && units != 0)
            {
                Purchase purchase = _purchases.Find(u => u.ProductName.ToLower().Equals(productName.ToLower()));
                if (purchase == null)
                {
                    Product prod = Store.Instance.AllProducts.Find(u => u.ProductName.ToLower().Equals(productName.ToLower()));
                    if (prod != null)
                    {
                        _purchases.Add(new Purchase(prod, units));
                    }
                }
                else
                {
                    purchase.Quantity += units;
                }
            }
        }

        public void RemovePurchaseFromCart(Purchase purchase)
        {
            if (_purchases.IndexOf(purchase) > -1)
            {
                _purchases.Remove(purchase);
            }
        }

        public void ClearPurchases()
        {
            if (_purchases != null && _purchases.Count > 0)
            {
                _purchases.Clear();
            }
        }
    }
}
