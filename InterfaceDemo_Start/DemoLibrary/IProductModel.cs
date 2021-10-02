using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public interface IProductModel
    {
        //Like a contract. These are the things that any class that implements the contract will have. Everything is public in an Interface. The methods don't have codes,
        //it is just saying these are the things the class will have.

        //The variables are property signatures and the methods are method signature. A signature is just the important bits. 

        string Title { get; set; }

        bool HasOrderBeenCompleted { get; }

        void ShipItem(CustomerModel customer);

    }
}
