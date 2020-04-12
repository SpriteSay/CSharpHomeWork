using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement
{
    [Serializable]
    public class Product
    {
        public string Id { get; }
        public string Name { get; }
        public double Price { get; set; }

        public Product() { }
        public Product(string id,string name,double price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return Id + '-' + Name + '-' + Price + "元";
        }
    }
}
