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
        int i = 0;
        Graphics g;
        ColorDialog co = new ColorDialog();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            g=  this.CreateGraphics();
            co.ShowDialog();
            Pen br = new Pen(co.Color,4);
            g.DrawRectangle(br, 250, 100, 50, 50);
            g.DrawRectangle(br, 50, 50, 200, 100);
            g.DrawEllipse(br, 60, 135, 30, 30);
            g.DrawEllipse(br, 100, 135, 30, 30);
            g.DrawEllipse(br, 255, 135, 30, 30);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Refresh();
            Pen br = new Pen(co.Color, 4);
            g.DrawRectangle(br, 250 + i, 100, 50, 50);
            g.DrawRectangle(br, 50 + i, 50, 200, 100);
            g.DrawEllipse(br, 60 + i, 135, 30, 30);
            g.DrawEllipse(br, 100 + i, 135, 30, 30);
            g.DrawEllipse(br, 255 + i, 135, 30, 30);
            i += 30;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}
