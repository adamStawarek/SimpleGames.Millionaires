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
    public partial class Win : Form
    {
        quizCart qC;
        public Win(quizCart q)
        {
            InitializeComponent();
            qC = q;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            qC.Hide();
            Form1 f = new Form1();
            f.ShowDialog();
            ds.stop();
        }
        private TForm getForm<TForm>() where TForm : Form
        {
            return (TForm)Application.OpenForms.OfType<TForm>().FirstOrDefault();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            qC.Close();
        }
        private DisplaySound ds;
        private void Win_Load(object sender, EventArgs e)
        {
            ds = new DisplaySound();
            ds.playSimpleSound(Properties.Resources.Ending_Music_1999);
        }
    }
}
