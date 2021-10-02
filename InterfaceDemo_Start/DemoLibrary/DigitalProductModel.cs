using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class DigitalProductModel : IProductModel, IDigitalProductModel
    {
        //We don't send a digital product like the physical but we would have something like an email address to email the product.
        public string Title { get; set; }

        public bool HasOrderBeenCompleted { get; private set;  }

        public int TotalDownloadsLeft { get; private set; } = 5;

        public void ShipItem(CustomerModel customer)
        {
            //Checks the order hasn't been completed (not downloaded everything). We email the information then subtract it from the total downloads until less than one downloads are left.
            if (HasOrderBeenCompleted == false)
            {
                Console.WriteLine($"Simulating shipping { Title } to { customer.EmailAddress}");
                TotalDownloadsLeft -= 1;
                if(TotalDownloadsLeft < 1)
                {
                    HasOrderBeenCompleted = true;
                    TotalDownloadsLeft = 0;
                }
            }



        }
    }
}
