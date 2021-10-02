using System;
using System.Collections.Generic;
using System.Text;

namespace FieldsDemoReadonly
{
    public class Customer
    {
        public int Id;
        public string Name;
        public readonly List<Order> Orders = new List<Order>();

        public Customer(int id)
        {
            this.Id = id;
        }
        //With this, it calls the first overload passing the id parameter.
        public Customer(int id, string name) : this(id)
        {
            this.Name = name;
        }

        public void Promote()
        {
            //Orders = new List<Order>();
            //...
        }
    }
}
