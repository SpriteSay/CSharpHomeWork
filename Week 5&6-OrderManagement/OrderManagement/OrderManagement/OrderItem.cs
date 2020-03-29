using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement
{
    [Serializable]
    public class OrderItem
    {
        public string Id { get; }
        public Product Prodc { get; set; }
        public int Num { get; set; }
        public double ItemPrice { get; }

        public OrderItem() { }

        public OrderItem(string id,Product p,int num)
        {
            Id = id;
            Prodc = p;
            Num = num;
            ItemPrice = Num * Prodc.Price;
        }

        public override bool Equals(object obj)
        {
            OrderItem odi = obj as OrderItem;
            return odi != null && Prodc.Name == odi.Prodc.Name;
        }

        public override string ToString()
        {

            return "[Item]"+Id + '\t' + Prodc + '\t' + Num + '\t' + ItemPrice + '\t';
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
