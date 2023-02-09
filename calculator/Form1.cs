namespace calculator
{
    public partial class Form1 : Form
    {
        double result;
        double num1 ,num2;
        int flag = -1;
        int newprocess = 0;
        public Form1()
        {
            InitializeComponent();
        }

        #region Buttons
        private void button1_Click(object sender, EventArgs e)
        {
            if(newprocess== 0)
            tb_show.Text += "1";
            else
            {
                tb_show.Text = string.Empty;
                newprocess = 0;
                tb_show.Text += "1";
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (newprocess == 0)
                tb_show.Text += "2";
            else
            {
                tb_show.Text = string.Empty;
                newprocess = 0;
                tb_show.Text += "2";
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (newprocess == 0)
                tb_show.Text += "3";
            else
            {
                tb_show.Text = string.Empty;
                newprocess = 0;
                tb_show.Text += "3";
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (newprocess == 0)
                tb_show.Text += "4";
            else
            {
                tb_show.Text = string.Empty;
                newprocess = 0;
                tb_show.Text += "4";
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (newprocess == 0)
                tb_show.Text += "5";
            else
            {
                tb_show.Text = string.Empty;
                newprocess = 0;
                tb_show.Text += "5";
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (newprocess == 0)
                tb_show.Text += "6";
            else
            {
                tb_show.Text = string.Empty;
                newprocess = 0;
                tb_show.Text += "6";
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (newprocess == 0)
                tb_show.Text += "7";
            else
            {
                tb_show.Text = string.Empty;
                newprocess = 0;
                tb_show.Text += "7";
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (newprocess == 0)
                tb_show.Text += "8";
            else
            {
                tb_show.Text = string.Empty;
                newprocess = 0;
                tb_show.Text += "8";
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (newprocess == 0)
                tb_show.Text += "9";
            else
            {
                tb_show.Text = string.Empty;
                newprocess = 0;
                tb_show.Text += "9";
            }
        }
        private void button0_Click(object sender, EventArgs e)
        {
            if (newprocess == 0)
                tb_show.Text += "0";
            else
            {
                tb_show.Text = string.Empty;
                newprocess = 0;
                tb_show.Text += "0";
            }
        }

        #endregion

        private void buttonsub_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(tb_show.Text);
            flag = 1;
            tb_show.Text = string.Empty;
        }

        private void buttonpius_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(tb_show.Text);
            flag = 2;
            tb_show.Text = string.Empty;
        }

        private void buttonmul_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(tb_show.Text);
            flag = 3;
            tb_show.Text = string.Empty;
        }

        private void buttonpow_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(tb_show.Text);
            flag = 4;
            tb_show.Text = string.Empty;
        }

        private void buttonequl_Click(object sender, EventArgs e)
        {
            if(flag==0)
            {
                result = num1 - double.Parse(tb_show.Text);
            }
            else if(flag==1)
            {
                result = num1 / double.Parse(tb_show.Text);
            }
            else if(flag==2) 
            {
                result = num1 + double.Parse(tb_show.Text);
            }
            else if(flag==3)
            {
                result = num1 * double.Parse(tb_show.Text);
            }
            else
            {
                double temp= 1;
                for(double i = 0; i <double.Parse(tb_show.Text);i++)
                {
                    temp *= num1;
                }
                result = temp;
            }
            tb_show.Text = result.ToString();
            flag = -1;
            newprocess = 1;
        }

        private void buttonminus_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(tb_show.Text);
            flag = 0;
            tb_show.Text = string.Empty;
        }


    }
}