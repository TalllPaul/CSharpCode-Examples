using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Shopping cart - simulated list of products that the customer has put in their cart. It is of type Interface, everything that goes into the cart will follow the interface type
            //allowing us to add different types to one list. 
            // One problem we have here is we can't add the newly created digital product to the cart. We can use an interface.
            List<IProductModel> cart = AddSampleData();
            //Gets customer details
            CustomerModel customer = GetCustomer();

            //Loops through every item in the cart, calls the ShipItem method for each item passing the customer details.
            foreach (IProductModel prod in cart)
            {
                //You can't access totaldownloads from the digital class with prod.TotalDownloadsLeft because, even though it is there, it is not established in the interface.
                prod.ShipItem(customer);
                
                //If the IProductModel contract is of interface IDigitalProductModel aswell, put it into the digital  variable.
                if(prod is IDigitalProductModel digital)
                {
                    Console.WriteLine($"For the { digital.Title } you have { digital.TotalDownloadsLeft } downloads left.");
                }
            }

            Console.ReadLine();
        }

        private static CustomerModel GetCustomer()
        {
            /*return new CustomerModel
            {
                FirstName = "Tim",
                LastName = "Corey",
                City = "Scranton",
                EmailAddress = "tim@IAmTimCorey.com",
                PhoneNumber = "555-1212"
            };*/

            return new CustomerModel { FirstName = "Paul", LastName = " Andrews", City = "Durango", EmailAddress = "yeah@outlook.com", PhoneNumber = "94848329" };
        }

        //Returns a List of products. 
        private static List<IProductModel> AddSampleData()
        {
            List<IProductModel> output = new List<IProductModel>();

            //Adds 4 products to the cart of object
            output.Add(new PhysicalProductModel { Title = "Nerf Football" });
            output.Add(new PhysicalProductModel { Title = "IAmTimCorey T-Shirt" });
            output.Add(new PhysicalProductModel { Title = "Hard Drive" });
            output.Add(new DigitalProductModel { Title = "Windows 10" });
            output.Add(new CourseProductModel { Title = ".NET Core start to finish" });

            return output;
        }
    }
}
