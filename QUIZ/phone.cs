using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUIZ
{
    public partial class phone : Form
    {
        public phone()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void txtUrl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                webBrowser1.Navigate(txtUrl.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUrl.Text))
            {
                webBrowser1.Navigate(txtUrl.Text);
            }
        }

        private void phone_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.facebook.com/messages/t/");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private int tick = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            tick++;
            label1.Text = (300 - tick).ToString();
            if (300 - tick == 30)
            {
                label1.ForeColor = Color.Red;
            }
            if (300 - tick == 0)
            {
                this.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
