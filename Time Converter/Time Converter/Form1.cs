using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Time_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ConverButton_Click(object sender, EventArgs e)
        {
            //Creating objects for the different times
            int entry, seconds, minutes, hours, days, result;

            if (int.TryParse(SecondsTextBox.Text, out entry))
            {
                

                //Clears each field instantly if the user wants to enter another number
                SecondsDisplay.Text = "";
                MinutesDisplay.Text = "";
                HoursDisplay.Text = "";
                DaysDisplay.Text = "";

                SecondsTextBox.Text = "";
                SecondsTextBox.Focus();

                //Turns the entry string into and int

                if (entry < 60)
                {
                    seconds = entry;

                    SecondsDisplay.Text = seconds.ToString();
                }



                else if (entry <= 3599)
                {
                    minutes = entry / 60;
                    seconds = entry % 60;

                    MinutesDisplay.Text = minutes.ToString();
                    SecondsDisplay.Text = seconds.ToString();
                }



                else if (entry <= 86399)
                {
                    hours = entry / 3600;
                    result = entry % 3600;
                    minutes = result / 60;
                    seconds = entry % 60;

                    HoursDisplay.Text = hours.ToString();
                    MinutesDisplay.Text = minutes.ToString();
                    SecondsDisplay.Text = seconds.ToString();
                }



                else if (entry > 86399)
                {
                    days = entry / 86400;
                    result = entry % 86400;
                    hours = result / 3600;
                    result = entry % 3600;
                    minutes = result / 60;
                    seconds = entry % 60;

                    HoursDisplay.Text = hours.ToString();
                    MinutesDisplay.Text = minutes.ToString();
                    SecondsDisplay.Text = seconds.ToString();
                    DaysDisplay.Text = days.ToString();
                }
            }

            else
            {
                MessageBox.Show("Please enter a number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }




            private void ClearButton_Click(object sender, EventArgs e)
            {
                SecondsDisplay.Text = "";
                MinutesDisplay.Text = "";
                HoursDisplay.Text = "";
                DaysDisplay.Text = "";

                SecondsTextBox.Text = "";
                SecondsTextBox.Focus();
            }

            private void CancelButton_Click(object sender, EventArgs e)
            {
                this.Close();
            }
        
    }
}
