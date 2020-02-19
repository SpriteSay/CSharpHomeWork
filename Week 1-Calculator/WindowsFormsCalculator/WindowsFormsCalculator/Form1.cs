using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsCalculator
{
    public partial class calculator : Form
    {
        double num1 = 0, num2 = 0, ans = 0;
        char opt = ' ', preopt = ' '; //opt为运算符，preopt为上一轮计算的运算符
        int equalpressed = 0;
        int n1hasvalue = 0, n2hasvalue = 0;
       
        //**************bug list************
        //按=之后不能再连续计算


        public calculator()
        {
            InitializeComponent();
        }
        
        //对num1和num2进行运算
        public void calculate(char operate)
        {
            switch (operate)
            {
                case '+':ans = num1 + num2; break;
                case '-':ans = num1 - num2; break;
                case '*':ans = num1 * num2; break;
                case '/':ans = num1 / num2; break;
                default:
                    try
                    {
                        ans = Convert.ToDouble(label1.Text); 
                    }
                    catch (System.FormatException)
                    {
                        label1.Text = "格式错误！";
                        label2.Text = "请点击CE重新计算";
                    }
                    break;
            }
            num1 = ans;
            n1hasvalue = 1;
            n2hasvalue = 0;
        }

        //按下符号键后,将label里的数值分配给num1或num2
        public void assign()
        {
            try
            {
                //num1有值，且num2无值时，将label1的数值赋给num2【1+2[+]】
                if (n1hasvalue == 1 && n2hasvalue == 0)
                {
                    if (equalpressed == 1)
                    {
                        label1.Text = "";
                    }
                    else
                    {
                        num2 = Convert.ToDouble(label1.Text);
                        n2hasvalue = 1;
                        label1.Text = "";
                        calculate(preopt);
                    }
                    label2.Text = Convert.ToString(num1) + opt;

                }
                //num1无值时，label1数值赋给num1 【1[+]】
                else
                {
                    label2.Text += label1.Text + opt;
                    num1 = Convert.ToDouble(label1.Text);
                    n1hasvalue = 1;
                    label1.Text = "";
                }
            }
            catch (System.FormatException)
            {
                label1.Text = "格式错误！";
                label2.Text = "请点击CE重新计算";
            }
            
        }

        //按下等于号操作
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                num2 = Convert.ToDouble(label1.Text);
                n2hasvalue = 1;
                calculate(opt);
                label1.Text = Convert.ToString(num1);
                label2.Text = "";
                equalpressed = 1;
                opt = ' ';
            }
            catch (System.FormatException)
            {
                label1.Text = "格式错误！";
                label2.Text = "请点击CE重新计算";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //*********基本数据**********
        private void button1_Click_1(object sender, EventArgs e)
        {
            label1.Text += "1";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text += "2";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text += "3";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text += "4";
        }
        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text += "5";
        }
        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text += "6";
        }
        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text += "7";
        }
        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text += "8";
        }
        private void button9_Click(object sender, EventArgs e)
        {
            label1.Text += "9";
        }
        private void button10_Click(object sender, EventArgs e)
        {
            label1.Text += "0";
        }
        private void dot_Click(object sender, EventArgs e)
        {
            label1.Text += ".";
        }

        //********四则运算*********
        private void add_Click(object sender, EventArgs e)
        {
            preopt = opt;
            opt = '+';
            assign();
        }
        private void sub_Click(object sender, EventArgs e)
        {
            preopt = opt;
            opt = '-';
            assign();
        }
        private void multiply_Click(object sender, EventArgs e)
        {
            preopt = opt;
            opt = '*';
            assign();
        }
        private void divide_Click(object sender, EventArgs e)
        {
            preopt = opt;
            opt = '/';
            assign();
        }

        //*********其他操作符**********
        private void backspace_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text.Substring(0, label1.Text.Length - 1);
        }
        private void clean_Click(object sender, EventArgs e)
        {
            label1.Text = "";
        }
        private void CE_Click(object sender, EventArgs e)
        {
            num1 = 0; num2 = 0;ans = 0;equalpressed = 0;
            n1hasvalue = 0;n2hasvalue = 0;
            opt = ' ';preopt = ' ';
            label1.Text = "";
            label2.Text = "";
        }
    }
}
