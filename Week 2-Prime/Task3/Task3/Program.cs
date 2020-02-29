using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        public void Calculate(bool[] isPrime)
        {
            for (int d = 2; d <= 100; d++)
            {
                for (int i = 2; i <= 100; i++)
                {
                    if (i % d == 0 && isPrime[i - 1] == true && i != d)
                    {
                        isPrime[i - 1] = false;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            Program pg = new Program();
            //初始化数组
            bool[] isPrime = new bool[100];
            for (int i = 0; i < 100; i++)
            {
                isPrime[i] = true;
            }

            Console.WriteLine("2-100内的素数有：");
            //埃氏筛选
            pg.Calculate(isPrime);
            
            //输出数据
            for (int i = 2; i < 100; i++)
            {
                if(isPrime[i-1] == true)
                {
                    Console.Write(i + " ");
                }
            }

        }
    }
}
