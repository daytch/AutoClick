using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UdemyProject
{
    public partial class Form1 : Form
    {
        private OpenChrome chrome;
        public Form1()
        {            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            string url = WebTargetInput.Text;
            int min = Convert.ToInt32(RangeID2Start.Text);
            int max = Convert.ToInt32(RangeID2End.Text);
            int idNow = Convert.ToInt32(ID2Input.Text);
            int rangeTime = Convert.ToInt32(LoopingInput.Text);

            int val = min + rand.Next(0, (max - min) / 2) * 2;

            url = (url.ToLower().Contains("http") || url.ToLower().Contains("https")) ? url : "http://" + url;
            chrome = new OpenChrome(url,min,max,idNow,rangeTime);
            chrome.Open();
        }
        private void ValidationWebTargetInput(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(WebTargetInput.Text))
            {
                e.Cancel = true;
                WebTargetInput.Focus();
                errorProvider1.SetError(WebTargetInput, "Web target should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(WebTargetInput, "");
            }
        }

        private void ValidationID2(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ID2Input.Text))
            {
                e.Cancel = true;
                WebTargetInput.Focus();
                errorMsgID2.SetError(ID2Input, "Parameter should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorMsgID2.SetError(ID2Input, "");
            }
        }

        private void ValidationLooping(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(LoopingInput.Text))
            {
                e.Cancel = true;
                WebTargetInput.Focus();
                errorLooping.SetError(LoopingInput, "Looping should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorLooping.SetError(LoopingInput, "");
            }
        }

        private void ValidationNumber(object sender, KeyPressEventArgs e)
        {
                if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == '\0' || e.KeyChar == (char)Keys.Back) //The  character represents a backspace
            {
                e.Handled = false; //Do not reject the input
            }
            else
            {
                e.Handled = true; //Reject the input
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            chrome.Stop();
        }
    }
}
