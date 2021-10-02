using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifiersDemo
{
    public class Customer
    {

        public int Id { get; set; }
        public string Name { get; set; }

        public void Promote()
        {
            var rating = CalculateRating(exludeOrders: true);
            if(rating == 0)
            {
                Console.WriteLine("Promoted to level 1");
            } else
            {
                Console.WriteLine("Promoted to level 2");
            }
        }

        //We don't need to see this method from the outside, only the Promote() method.
        protected int CalculateRating(bool exludeOrders)
        {
            return 0;
        }

    }
}
