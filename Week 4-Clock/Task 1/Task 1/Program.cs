using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        //1、为示例中的泛型链表类添加类似于List<T>类的ForEach(Action<T> action)方法。
        //通过调用这个方法打印链表元素，求最大值、最小值和求和（使用lambda表达式实现）。
        static void Main(string[] args)
        {
            int sum = 0;
            Random rd = new Random();
            GenericList<int> list = new GenericList<int>();
            for (int i = 0; i < 10; i++)
            {
                list.Add(rd.Next()%100);
            }
            int max = list.Head.Data;
            int min = list.Head.Data;

            list.ForEach(n => Console.WriteLine(n));
            list.ForEach(n => sum += n);
            list.ForEach(n => { max = max > n ? max : n; });
            list.ForEach(n => { min = min < n ? min : n; });

            Console.WriteLine("最大值是：" + max);
            Console.WriteLine("最小值是：" + min);
            Console.WriteLine("总和是：" +sum);


        }
    }
}
