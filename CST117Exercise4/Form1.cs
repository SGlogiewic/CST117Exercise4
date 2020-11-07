using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST117Exercise4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int secondsEntered, minutesOutput, hoursOutput, daysOutput;
                secondsEntered = int.Parse(textBox1.Text);

                if (secondsEntered >= 60 && secondsEntered <= 3600)
                {
                    minutesOutput = secondsEntered / 60;
                    label2.Text = secondsEntered + " seconds converts to " + minutesOutput + " minute(s).";
                }

                else if(secondsEntered >= 3600 && secondsEntered <= 86400)
                {
                    minutesOutput = secondsEntered / 60;
                    label5_secondsToMinutes.Text = secondsEntered + " seconds converts to " + minutesOutput + " minute(s).";
                    hoursOutput = secondsEntered / 3600;
                    label3.Text = secondsEntered + " seconds converts to " + hoursOutput + " hour(s).";
                }

                else if (secondsEntered >= 86400)
                {
                    minutesOutput = secondsEntered / 60;
                    label5_secondsToMinutes.Text = secondsEntered + " seconds converts to " + minutesOutput + " minute(s).";
                    hoursOutput = secondsEntered / 3600;
                    label6_secondsToHours.Text = secondsEntered + " seconds converts to " + hoursOutput + " hour(s).";
                    daysOutput = secondsEntered / 86400;
                    label7_secondsToDays.Text = secondsEntered + " seconds converts to " + daysOutput + " day(s).";
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Input must be a whole number under 10 digits long.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label7_secondsToDays_Click(object sender, EventArgs e)
        {

        }

        private void label5_secondsToMinutes_Click(object sender, EventArgs e)
        {

        }

        private void label6_secondsToHours_Click(object sender, EventArgs e)
        {

        }
    }
}
