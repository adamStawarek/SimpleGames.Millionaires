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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Settings s = new Settings();
            s.Show();                      
        }
        private DisplaySound ds;
        private void Form1_Load(object sender, EventArgs e)
        {
            ds= new DisplaySound();
            ds.playInLoop(Properties.Resources.Round_1_music);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AddQuestAndAns aqa = new AddQuestAndAns();
            aqa.ShowDialog();
        }
    }
}
