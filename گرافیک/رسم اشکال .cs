using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        int x1, y1, x2, y2;
        Pen p1;
        Brush b1;
        Graphics g;
        ColorDialog co = new ColorDialog();
        string shape;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            x1 = e.X;
            y1 = e.Y;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            b1 = new SolidBrush(Color.Black);
            p1 = new Pen(Color.Black);
            g = this.CreateGraphics();
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            x2 = e.X;
            y2 = e.Y;
            g = this.CreateGraphics();
            if (shape == "l")
                g.DrawLine(p1, x1, y1, x2, y2);
            else if (shape == "r")
                g.DrawRectangle(p1, x1, y1, x2 - x1, y2 - y1);
            else if (shape == "e")
                g.DrawEllipse(p1, x1, y1, x2 - x1, y2 - y1);
            else if (shape == "rp")
                g.FillRectangle(b1, x1, y1, x2 - x1, y2 - y1);
            else if (shape == "ep")
                g.FillEllipse(b1, x1, y1, x2 - x1, y2 - y1);
            else
                g.FillPie(b1, x1, y1, x2, y2, 0, 90);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            co.ShowDialog();
            b1 = new SolidBrush(co.Color);
            p1 = new Pen(co.Color);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            shape = "l";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            shape = "r";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            shape = "e";
        }
        
        private void button5_Click(object sender, EventArgs e)
        {
            shape = "rp";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            shape = "ep";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            shape = "p";
        }
    }
}
