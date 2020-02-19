using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;
            Console.WriteLine("***********加减乘除计算器***********");

            try
            {
                Console.WriteLine("输入第一个数：");
                num1 = Convert.ToDouble(Console.ReadLine());
            }
            catch (System.FormatException)
            {
                Console.WriteLine("您输入的数据不合法，请重新输入！");
                num1 = Convert.ToDouble(Console.ReadLine());
            }
            try
            {
                Console.WriteLine("输入第二个数：");
                num2 = Convert.ToDouble(Console.ReadLine());
            }
            catch (System.FormatException)
            {
                Console.WriteLine("您输入的数据不合法，请重新输入！");
                num2 = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("输入符号（+ - * /）:");

            switch (Console.ReadLine())
            {
                case "+":
                    Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
                    break;
                case "-":
                    Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
                    break;
                case "*":
                    Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
                    break;
                case "/":
                    while(num2 == 0)
                    {
                        Console.WriteLine("被除数不能为0，请重新输入！");
                        Console.WriteLine("输入第二个数：");
                        num2 = Convert.ToDouble(Console.ReadLine());
                    }
                    Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
                    break;
            }
        }
    }
}
