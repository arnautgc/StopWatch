using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Stopwatch crono = new Stopwatch();

        public Form1()
        {
            InitializeComponent();
           
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            crono.Reset();
            crono.Start();
            timer1.Enabled = true;
            this.Icon = new System.Drawing.Icon("blau.ico");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Get the elapsed time as a TimeSpan value.
            TimeSpan ts = crono.Elapsed;

            // Format and display the TimeSpan value.
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:0}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds/100);
            l1.Text = elapsedTime;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            crono.Stop();
            timer1.Enabled = false;
            this.Icon = new System.Drawing.Icon("logo.ico");
        }
    }
}
