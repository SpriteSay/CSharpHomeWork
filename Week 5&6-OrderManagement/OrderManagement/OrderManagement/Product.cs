using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement
{
    [Serializable]
    public class Product
    {
        [Key]
        public string ID { get; set; }

        public string Name { get; }
        public double Price { get; set; }

        public Product() {
            ID = Guid.NewGuid().ToString();
        }
        public Product(string name,double price)
        {
            ID = Guid.NewGuid().ToString();
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return ID + '-' + Name + '-' + Price + "元";
        }
    }
}
