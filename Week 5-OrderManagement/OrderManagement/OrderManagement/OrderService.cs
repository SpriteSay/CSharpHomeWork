using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement
{
    class OrderService
    {
        public List<Order> orders { get; }

        public OrderService(List<Order> ods)
        {
            orders = ods;
        }

        public void AddOrder(Order od)
        {
            if (!orders.Contains(od))
            {
                orders.Add(od);
                return;
            }
            Exception e = new Exception("不能添加重复项！");
            throw e;

        }
        public void DeleteOrder(Order od)
        {
            if (orders.Contains(od))
            {
                orders.Remove(od);
                return;
            }
            Exception e = new Exception("表单中无此项！");
            throw e;
        }
        public void ChangeOrder(Order od,Client client)
        {
            od.Client = client;
        }
        public void ChangeOrder(Order od,string addr)
        {
            od.Address = addr;
        }
        public void ChangeOrder(Order od,List<OrderItem> li)
        {
            od.Items = li;
        }

        public IEnumerable<Order> SearchOrder(int opt,string info)
        {
            switch (opt)
            {
                case 1: //订单号查询
                    var query1 = from od1 in orders where od1.OrderId == info
                                 orderby od1.TotalPrice
                                 select od1;
                    return query1;
                case 2: //商品名称查询
                    var query2 = from od2 in orders
                                 from items in od2.Items
                                 where items.Prodc.Name == info
                                 select od2;
                    return query2;
                case 3: //客户查询
                    var query3 = from od3 in orders where od3.Client.ToString() == info
                                 orderby od3.TotalPrice
                                 select od3;
                    return query3;
                default:
                    return null;
            }
        }

        public override string ToString()
        {
            string s = "";
            foreach (Order od in orders)
            {
                s += od + "\r\n";
            }
            return s;
        }

        public void SortOrder()
        {
            orders.Sort();
        }

        public void SortOrder(Comparison<Order> comp)
        {
            orders.Sort(comp);
        }

    }
}
