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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }
        private string scenario="S";
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            quizCart qC = new quizCart(scenario);
            qC.Show();
        }

        private void ChooseScenario(object sender, EventArgs e)
        {
            this.button1.Enabled = true;
            PictureBox pb = sender as PictureBox;
            if (pb.Equals(pictureBox1))
            {
                scenario = "S";
                pictureBox1.BackgroundImage = Properties.Resources.indeks;
                pictureBox2.BackgroundImage = Properties.Resources.N2;
                pictureBox3.BackgroundImage = Properties.Resources.PRL2;
            }
            else if (pb.Equals(pictureBox2))
            {
                scenario = "N";
                pictureBox1.BackgroundImage = Properties.Resources.S2;
                pictureBox2.BackgroundImage = Properties.Resources.bbc9154ba1758b447e8c7547fe0f;
                pictureBox3.BackgroundImage = Properties.Resources.PRL2;

            }
            else
            {
                scenario = "PRL";
                pictureBox1.BackgroundImage = Properties.Resources.S2;
                pictureBox2.BackgroundImage = Properties.Resources.N2;
                pictureBox3.BackgroundImage = Properties.Resources.absurdy_prl_23814353;
            }
        }
    }
}
