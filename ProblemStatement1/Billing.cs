using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemStatement1
{
    class Billing
    {

        private Cart _cart;
        private StringBuilder _finalBill;
        private decimal _total = 0;

        public string FinalBill
        {
            get { return _finalBill.ToString(); }
        }


        public Billing(Cart cart)
        {
            _cart = cart;
            _finalBill = new StringBuilder();
        }

        public void bill()
        {
            decimal totals = 0;            

            PromotionFactory.Instance().PromotionOneInstance.bill(_cart.AllPurchases, ref _finalBill, ref totals);
            _total += totals;

            PromotionFactory.Instance().PromotionTwoInstance.bill(_cart.AllPurchases, ref _finalBill, ref totals);
            _total += totals;

            PromotionFactory.Instance().bill(_cart.AllPurchases, ref _finalBill, ref totals);
            _total += totals;

            _finalBill.Append("\n================\n");
            _finalBill.Append("Total\t"+ _total);
        }
    }
}
