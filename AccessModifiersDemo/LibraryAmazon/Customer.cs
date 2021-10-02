using System;
using System.Collections.Generic;
using System.Text;

//This class library creates a dll which is a linked library that can be used in other applications. 

namespace LibraryAmazon
{
    public class Customer
    {

        public int Id { get; set; }
        public string Name { get; set; }

        public void Promote()
        {

                var calculator = new RateCalculator();
                var rating = calculator.Calculate(this);
          
        }

        //We don't need to see this method from the outside, only the Promote() method.
        protected int CalculateRating(bool exludeOrders)
        {
            return 0;
        }

    }
}
