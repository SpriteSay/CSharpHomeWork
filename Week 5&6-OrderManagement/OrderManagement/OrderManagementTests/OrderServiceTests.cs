using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement.Tests
{
    [TestClass()]
    public class OrderServiceTests
    {
        Product p1, p2, p3;
        Client c1, c2;
        OrderItem odi1, odi2, odi3, odi4;
        List<OrderItem> l1, l2, l3;

        Order od1, od2, od3;

        List<Order> orders;
        OrderService ods;


        [TestInitialize]
        public void TInitialize()
        {
            //生成商品
            p1 = new Product("p01", "苹果", 5);
            p2 = new Product("p02", "橙子", 7);
            p3 = new Product("p03", "梨", 4);

            //生成客户
            c1 = new Client("c01");
            c2 = new Client("c02");

            //生成订单项
            odi1 = new OrderItem("i01", p1, 1);
            odi2 = new OrderItem("i02", p2, 2);
            odi3 = new OrderItem("i03", p3, 3);
            odi4 = new OrderItem("i04", p2, 4);

            //生成订单项列表
            l1 = new List<OrderItem>();
            l2 = new List<OrderItem>();
            l3 = new List<OrderItem>();

            l1.Add(odi1);
            l1.Add(odi2);
            l2.Add(odi4);
            l2.Add(odi3);
            l3.Add(odi1);

            //生成订单
            od1 = new Order("o01", c1, "address1", l1);
            od2 = new Order("o02", c1, "address2", l2);
            od3 = new Order("o03", c1, "address3", l3);

            orders = new List<Order>();

            //生成订单服务对象
            ods = new OrderService(orders);
            ods.AddOrder(od1);
            ods.AddOrder(od2);

        }

        [TestCleanup]
        public void TClearUp()
        {
            ////清空商品
            //p1 = null; p2 = null; p3 = null;

            ////清空客户
            //c1 = null;

            ////清空订单项
            //odi1 = null;odi2 = null;odi3 = null;odi4 = null;

            ////清空订单项列表
            //l1 = null;l2 = null;l3 = null;

            ////清空订单
            //od1 = null; od2 = null;od3 = null;
            //orders = null;

            //清空订单服务对象
            ods = new OrderService();
        }


        [TestMethod()]
        public void AddOrderTest()
        {
            ods.AddOrder(od3);
            Assert.AreEqual(3, ods.orders.Count);
            CollectionAssert.Contains(ods.orders, od1);
        }

        [TestMethod()]
        public void DeleteOrderTest()
        {
            ods.DeleteOrder(od1);
            Assert.AreEqual(1, ods.orders.Count);
            CollectionAssert.DoesNotContain(ods.orders, od1);
        }

        [TestMethod()]
        public void SearchOrderTest()
        {
            IEnumerable<Order> result1 = ods.SearchOrder(1, "o01");
            Assert.AreEqual(1, result1.Count());
            IEnumerable<Order> result2 = ods.SearchOrder(2, "苹果");
            Assert.AreEqual(1, result2.Count());
            IEnumerable<Order> result3 = ods.SearchOrder(3, "c01");
            Assert.AreEqual(2, result3.Count());
        }

        [TestMethod()]
        public void ChangeOrderTest1()
        {
            ods.ChangeOrder(od1, c2);
            Assert.AreEqual(c2, od1.Client);
        }

        [TestMethod()]
        public void ChangeOrderTest2()
        {
            ods.ChangeOrder(od1, "北京");
            Assert.AreEqual("北京", od1.Address);
        }

        [TestMethod()]
        public void ChangeOrderTest3()
        {
            ods.ChangeOrder(od1, l2);
            Assert.AreEqual(l2, od1.Items);
        }

        [TestMethod()]
        public void ExportTest()
        {
            string file = "orders.xml";
            ods.Export(file);
            Assert.IsTrue(File.Exists(file));
            //File.ReadLines(file);
        }

    }
}