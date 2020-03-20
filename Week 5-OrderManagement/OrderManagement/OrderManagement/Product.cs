using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement
{
    class Product
    {
        public string Id { get; }
        public string Name { get; }
        public double Price { get; set; }

        public Product(string id,string name,double price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return Id + '\t' + Name + '\t' + Price;
        }
    }
}
