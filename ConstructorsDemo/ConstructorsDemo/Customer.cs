using System;
using System.Collections.Generic;
using System.Text;

namespace ConstructorsDemo
{
    public class Customer
    {
        public int Id;
        public string Name;
        //Always initialise an empty List when working with Lists.
        public List<Order> Orders;

        public Customer()
        {
            //Initialise empty list.
            Orders = new List<Order>();
        }
        //Adding this() calls the empty constructor to initialise the List before setting the ID value.
        public Customer(int id) : this() { 
            this.Id = id;
        }

        public Customer(int id, string name) : this()
        {
            this.Id = id;
            this.Name = name;
        }
    }
}
