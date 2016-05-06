using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace ShutdownTimer
{
    public partial class ShutdownTimer : Form
    {
        public ShutdownTimer()
        {
            InitializeComponent();
        }
        int Duration;
        #region MiscStuff
        private void ShutdownTimer_Resize(object sender, EventArgs e)
        {
              //Checks to see if the window has been minimized and hides it from taskbar and enables notifyicon.
            if (WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                shutdownIcon.Visible = true;

            }
        }

        private void shutdownIcon_MouseDoubleClick(object sender, MouseEventArgs e) //Unn minimizes an application.
        {
             
            if (WindowState == FormWindowState.Minimized)
             {
                this.Show();
                WindowState = FormWindowState.Normal;
                shutdownIcon.Visible = false;

             } 
        }

        private void TimerText_KeyPress(object sender, KeyPressEventArgs e) //Prevents text from being entered into the textbox not a perfect solution.
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        #endregion



        private void startButton_Click(object sender, EventArgs e) 
        {
           if(timerText.Text != ""  && Duration == 0)  //Converts the user entered duration from the textbox to a int then starts the timer.
            {
                Duration = Convert.ToInt32(timerText.Text);
                shutdownTime.Enabled = true;
                shutdownTime.Start();
                startButton.Enabled = false;
                pauseButton.Enabled = true;
            }
           else if(timerText.Text == "") //Prompt the user to enter a number if the textbox is left blank.
            {
                MessageBox.Show("Please enter a duration in seconds into the text box.");
            }

           if(Duration > 0)    //For the resume feature to prevent  a crash trying to convert timespan to an int.
            {
                shutdownTime.Start();
                startButton.Enabled = false;
                pauseButton.Enabled = true;
            }
        }

        private void shutdownTime_Tick(object sender, EventArgs e)  //Removes 1 from the duration every tick then shutsdown when Duration reaches 0
        {
            Duration--;
            timerText.Text = TimeSpan.FromSeconds(Duration).ToString();

            if(Duration <= 0)
            {
                Process.Start("shutdown", "/s /t 0");
            }
            
        }

        private void pauseButton_Click(object sender, EventArgs e) //Pauses the timer
        {
            shutdownTime.Stop();
            startButton.Text = "Resume";
            startButton.Enabled = true;
            pauseButton.Enabled = false;
            
        }

       
    }
}
