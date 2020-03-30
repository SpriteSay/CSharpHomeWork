using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cayley
{
    public partial class Form1 : Form
    {

        private Graphics graphics;
        double th1 = 30 * Math.PI / 180;
        double th2 = 20 * Math.PI / 180;
        double per1 = 0.6;
        double per2 = 0.7;
        Pen pen = Pens.Orange;
        int depth = 10;
        int length = 100;

        public Form1()
        {
            InitializeComponent();
            txtDepth.Text = "10";
            txtLeftPer.Text = "0.7";
            txtRightPer.Text = "0.6";
            txtLength.Text = "100";
            txtLeftTh.Text = "0.349";
            txtRightTh.Text = "0.523";

        }

        void DrawCayleyTree(int n,double x0,double y0,
            double leng,double th)
        {
            if (n == 0) return;
            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);

            graphics.DrawLine(pen, (int)x0, (int)y0, (int)x1, (int)y1);
            DrawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1);
            DrawCayleyTree(n - 1, x1, y1, per2 * leng, th - th2);

        }


        private void button1_Click(object sender, EventArgs e)
        {
            if(graphics!=null)  graphics.Clear(panel1.BackColor);
            switch (cmbColor.Text)
            {
                case "蓝色": pen = Pens.Blue; break;
                case "绿色": pen = Pens.Green; break;
                case "红色": pen = Pens.Red; break;
                case "黄色": pen = Pens.Yellow; break;
                case "紫色": pen = Pens.Purple; break;
                default: pen = Pens.Blue; break;
            }
            try
            {
                per2 = Convert.ToDouble(txtLeftPer.Text);
                per1 = Convert.ToDouble(txtRightPer.Text);
                th2 = Convert.ToDouble(txtLeftTh.Text);
                th1 = Convert.ToDouble(txtRightTh.Text);
                depth = Convert.ToInt32(txtDepth.Text);
                length = Convert.ToInt32(txtLength.Text);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("输入数据有误，请重新输入！");
            }

            if (graphics == null) graphics = panel1.CreateGraphics();
            DrawCayleyTree(depth, 200, 310, length, -Math.PI / 2);
        }
    }
}
