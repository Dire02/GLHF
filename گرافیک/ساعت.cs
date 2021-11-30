using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        int i = 0;
        int j = 0;
        int a = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Refresh();
            Graphics g = this.CreateGraphics();
            Pen p1 = new Pen(Color.Red, 2);
            Pen p2 = new Pen(Color.Blue, 2);
            Pen p3 = new Pen(Color.Green, 2);
            g.DrawEllipse(p1, 50, 50, 300, 300);

            i = DateTime.Now.Second * 6 + 270;
            j = DateTime.Now.Minute * 6 + 270;
            a = DateTime.Now.Hour * 30 + 270;
            g.DrawPie(p2, 50, 50, 300, 300, j, 1);
            g.DrawPie(p1, 50, 50, 300, 300, i, 1);
            g.DrawPie(p3, 50, 50, 300, 300, a, 1);

            Brush br = new SolidBrush(Color.Black);
            g.DrawString("12", fontDialog1.Font, br, new PointF(190, 50));
            g.DrawString("3", fontDialog1.Font, br, new PointF(340, 190));
            g.DrawString("6", fontDialog1.Font, br, new PointF(195, 340));
            g.DrawString("9", fontDialog1.Font, br, new PointF(50, 190));


        }
    }
}
