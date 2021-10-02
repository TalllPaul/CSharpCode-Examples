using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifiersDemo
{
   public class GoldCustomer: Customer
    {
        public void OfferVoucher()
        {
            var rating = this.CalculateRating(exludeOrders: true);
        }
    }
}
