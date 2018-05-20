using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace QUIZ
{
    public partial class wykresy : Form
    {
        int correctNum=0;
        public wykresy(int corr)
        {
            InitializeComponent();
            correctNum = corr;
        }
        private void wykresy_Load(object sender, EventArgs e)
        {
            Random r = new Random();
            int total = 100;
            int Sa = r.Next(total-25)+20;
            int Sb= r.Next(total-Sa+ 5);
            int Sc = r.Next(total - Sa-Sb+ 5 );
            int Sd = r.Next(total - Sa-Sb-Sc+ 5 );
            List<int> numbers = new List<int>();
            numbers.Add(Sb);
            numbers.Add(Sc);
            numbers.Add(Sd);
            Shuffle(numbers);

            //AddXY value in chart1 in series named as Salary  
            chart1.Series["Series1"].Points.AddXY(".A",Sa);
            chart1.Series["Series1"].Points.AddXY(".B",Sb);
            chart1.Series["Series1"].Points.AddXY(".C",Sc);
            chart1.Series["Series1"].Points.AddXY(".D",Sd);


            chart1.Series["Series1"].Points.ElementAt(correctNum).SetValueY(Sa);
            foreach (DataPoint p in chart1.Series["Series1"].Points)
            {
                if (!p.Equals(chart1.Series["Series1"].Points.ElementAt(correctNum)))
                {
                    p.SetValueY(numbers.First());
                    numbers.RemoveAt(0);
                }
            }
        }
        private Random rng = new Random();

        public void Shuffle(List<int> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                int value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}
