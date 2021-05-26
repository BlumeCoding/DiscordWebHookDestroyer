using System;
using System.Collections.Generic;
using System.IO;
using System.Management;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace DiscordWebHookFucker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (DcWebHooker dcWeb = new DcWebHooker())
            {
                {
                    dcWeb.UserName = textBox3.Text;
                    timer1.Start();

                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            using (DcWebHooker dcWeb = new DcWebHooker())
            {
                {
                    timer1.Interval = (int)this.numericUpDown1.Value;
                    dcWeb.WebHook = textBox2.Text;
                    dcWeb.ProfilePicture = "https://memegenerator.net/img/instances/29984422.jpg";
                   
                    dcWeb.SendMessage(textBox1.Text);
                }
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
           // timer1.Interval = (int)this.numericUpDown1.Value;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
    }
