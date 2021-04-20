using System;
using System.Windows.Forms;

namespace Quiz
{
    public partial class Form1 : Form
    {
        public Random randomizer = new Random();

        public int andend1, andend2, timeLeft, minus1, minus2, multi1, multi2, divi1, divi2;

        private bool CheckTheAnswer()
        {
            if ((andend1 + andend2 == sum.Value)
                && (minus1 - minus2 == difference.Value)
                && (multi1 * multi2 == product.Value)
                && (divi1 / divi2 == quotient.Value))
            { 
                return true;
            }
            return false;
        }

        private void TimerTick(object sender, EventArgs e)
        {
            if(CheckTheAnswer())
            {
                timer1.Stop();
                MessageBox.Show("Congrats! You got all the answers right.");
            }
            else if (timeLeft >0)
            {
                timeLeft = timeLeft - 1;
                timeLabel.Text = timeLeft + " seconds";
            }
            else 
            {
                timer1.Stop();
                timeLabel.Text = "Time is up!";
                sum.Value = andend1 + andend2;
                difference.Value = minus1 - minus2;
                product.Value = multi1 * multi2;
                quotient.Value = divi1 / divi2;
            }
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            andend1 = randomizer.Next(51);
            andend2 = randomizer.Next(51);
            plusLeftLabel.Text = andend1.ToString();
            plusRightLabel.Text = andend2.ToString();
            sum.Value = 0;

            minus1 = randomizer.Next(1, 101);
            minus2 = randomizer.Next(1, minus1);
            minusLeftLabel.Text = minus1.ToString();
            minusRightLabel.Text = minus2.ToString();
            difference.Value = 0;

            multi1 = randomizer.Next(2, 11);
            multi2 = randomizer.Next(2, 11);
            timesLeftLabel.Text = multi1.ToString();
            timesRightLabel.Text = multi2.ToString();
            product.Value = 0;

            divi2 = randomizer.Next(2, 11);
            int temp = randomizer.Next(2, 11);
            divi1 = divi2 * temp;
            dividedLeftLabel.Text = divi1.ToString();
            dividedRightLabel.Text = divi2.ToString();
            quotient.Value = 0;

            timeLeft = 30;
            timeLabel.Text = "30 seconds";
            timer1.Start();
        }

        public Form1()
        {
            InitializeComponent();
        }
    }
}
