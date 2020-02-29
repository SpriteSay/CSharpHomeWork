using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        public void Calculate(int[] ary,out int max,out int min,out int eval,out int sum)
        {
            max = ary[1] > ary[0] ? ary[1] : ary[0];
            min = ary[1] > ary[0] ? ary[0] : ary[1];
            sum = 0;

            for (int i = 0; i < ary.Length; i++)
            {
                max = ary[i] > max ? ary[i] : max;
                min = ary[i] < min ? ary[i] : min;
                sum += ary[i];
            }
            eval = sum / ary.Length;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("请输入数组长度：");
            int maxLegth = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[maxLegth];

            Program pg = new Program();

            //数组初始化
            Console.WriteLine("请输入数组元素（回车输入下一个）：");
            for (int i = 0; i < maxLegth; i++)
            {
                int m = Convert.ToInt32(Console.ReadLine());
                array[i] = m;
            }
            int max = 0, min = 0, eval = 0, sum = 0;
            pg.Calculate(array,out max,out min,out eval,out sum);
            Console.WriteLine("最小值：" + min + " 最大值：" + max + " 平均值：" + eval + " 所有数之和：" + sum);

        }
    }
}
