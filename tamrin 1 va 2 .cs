  public partial class Form1 : Form

    {
        TextBox[,] matris1;
        TextBox[,] matris2;
        TextBox[,] matris3;
        TextBox[,] matris4;
        public Form1()
        {
            InitializeComponent();


        }

        public void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);

            Label one = new Label();
            one.Text = "First Matris  : ";
            one.Location = new Point(50, 70);
            this.Controls.Add(one);

            Label two = new Label();
            two.Text = "Second Matris  : ";
            two.Location = new Point(500, 70);
            this.Controls.Add(two);


            matris1 = new TextBox[a, a];
            matris2 = new TextBox[a, a];
            for (int i =0; i< a; i++)
                for(int j = 0; j<a ; j++)
                {
                    
                    matris1[i, j] = new TextBox();
                    matris1[i, j].Size = new Size(40, 20);
                    matris1[i, j].Location = new Point(i * 42 + 50, j * 21 + 100);

                    this.Controls.Add(matris1[i, j]);

                    matris2[i, j] = new TextBox();
                    matris2[i, j].Size = new Size(40, 20);
                    matris2[i, j].Location = new Point(i * 42 + 500, j * 21 + 100);

                    this.Controls.Add(matris2[i, j]);
                }
        }

        public void button2_Click(object sender, EventArgs e)
        {
           
            int a = int.Parse(textBox1.Text);


            Label three = new Label();
            three.Text = " First Matris Plus Second Matris Equals  : ";
            three.Size = new Size(240, 20);
            three.Location = new Point(50, 270);
            this.Controls.Add(three);


            matris3 = new TextBox[a, a];

              for (int i = 0; i < a; i++)
                for (int j = 0; j < a; j++)
                {
                    matris3[i, j] = new TextBox();
                    matris3[i, j].Size = new Size(40, 20);
                    matris3[i, j].Location = new Point(i * 42 + 50, j * 21 + 300);

                    this.Controls.Add(matris3[i, j]);
               
                     matris3[i, j].Text =(int.Parse( matris1[i,j].Text) * int.Parse(matris2[i,j].Text)).ToString();

                }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);


            Label four = new Label();
            four.Text = " First Matris Multiply Second Matris Equals  : ";
            four.Size = new Size(240, 20);
            four.Location = new Point(500, 270);
            this.Controls.Add(four);


            matris4 = new TextBox[a, a];

            for (int i = 0; i < a; i++)
                for (int j = 0; j < a; j++)
                {
                    matris4[i, j] = new TextBox();
                    matris4[i, j].Size = new Size(40, 20);
                    matris4[i, j].Location = new Point(i * 42 + 500, j * 21 + 300);

                    this.Controls.Add(matris4[i, j]);

                    matris4[i, j].Text = (int.Parse(matris1[i, j].Text) * int.Parse(matris2[i, j].Text)).ToString();

                }

        }
    }