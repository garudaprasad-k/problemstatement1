using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemStatement1
{
    public interface IPromotion
    {
        void bill(List<Purchase> purchases, ref StringBuilder billAsString, ref decimal total);
    }
}
