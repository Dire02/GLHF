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
        public Form1()
        {
            InitializeComponent();
        }

        public void reverse(ref int a)
        {
            int n=a ,reverse = 0, rem;
            while (n!= 0)
            {
                rem = n % 10;
                reverse = reverse * 10 + rem;
                n /= 10;
            }
            a = reverse;

        }
        private void button1_Click(object sender, EventArgs e)
        {

           int a = int.Parse(textBox1.Text);
            reverse(ref a);
            label1.Text = a.ToString();

        }
    }
}
