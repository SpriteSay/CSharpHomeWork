using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime
{
    class Program
    {
        //埃式筛法判断素数
        public bool IsPrime(int n)
        {
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个数据：");

            int a = Convert.ToInt32(Console.ReadLine());
            Program pg = new Program();
            if (a >= 2)
            {
                Console.WriteLine("它的素数因子是：");
                for (int i = 2; i <= a; i++)
                {
                    if (pg.IsPrime(i) && a % i == 0)
                    {
                        Console.Write(i + " ");
                    }
                }
            }
            else
            {
                Console.WriteLine("您必须输入一个大于1的自然数");

            }
        }
    }
}

