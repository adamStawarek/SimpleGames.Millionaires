using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUIZ
{
    public partial class quizCart : Form
    {
        public quizCart(string s)
        {
            InitializeComponent();
            ds = new DisplaySound();
            scenario = s;
        }
        private DisplaySound ds;
        private string scenario;

        private void quizCart_Load(object sender, EventArgs e)
        {
                     
            answers = new List<Button>();
            answers.Add(ansA);
            answers.Add(ansB);
            answers.Add(ansC);
            answers.Add(ansD);
            foreach(Button b in answers)
            {
                b.BackColor = Color.Wheat;
                b.FlatStyle = FlatStyle.Flat;
                b.FlatAppearance.BorderSize = 3;
                b.FlatAppearance.BorderColor = Color.White;
            }
            loadNewQuestion();
        }
        private int currentQuestion = 1;
        private List<Button> answers;
        private Button correctAns;
        private int correctNumb = 0;
        private bool PlayerWon = false,GameOver=false;

        private void loadNewQuestion()
        {
            //wersja z Sql server
            //SqlConnection conn = new SqlConnection("Server=DESKTOP-BO91STR\\SQLEXPRESS;Database=Quiz;Integrated Security=true");
            //conn.Open();

            //wersja z azure
            /*SqlConnection conn = null;
            try
            {
                var cb = new SqlConnectionStringBuilder();
                cb.DataSource = "serv2703.database.windows.net";
                cb.PersistSecurityInfo = false;
                cb.MultipleActiveResultSets = false;
                cb.Encrypt = true;
                cb.TrustServerCertificate = false;
                cb.ConnectTimeout = 30;
                cb.UserID = "adam";
                cb.Password = "Kaczor100.";
                cb.InitialCatalog = "Quiz";

                conn = new SqlConnection(cb.ConnectionString);
                conn.Open();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }*/

            //część uniwersalna dla sql
            // SqlCommand cmd = new SqlCommand(
            //     "Select q.Description from Questions2 q where q.Topic='"+scenario+"' and q.Difficulty="+currentQuestion+"", conn);
            // SqlDataReader reader = cmd.ExecuteReader();
            // while (reader.Read())
            // {
            //     Quest.Text = reader.GetString(0);
            //     Question.Text = "Question" + currentQuestion;

            // }
            // cmd=new SqlCommand(
            //     "select a.[Description] , a.IsCorrect from Questions2 q join Answers2 a on a.QuestionId = q.QuestionId where q.Topic='" + scenario + "' and q.Difficulty =" + currentQuestion + "", conn);
            // reader.Close();
            //reader = cmd.ExecuteReader();
            // int currentans = 0;
            // while (reader.Read())
            // {
            //     answers.ElementAt(currentans).Text=reader.GetString(0);
            //     if (reader.GetBoolean(1))
            //     {
            //         correctAns = answers.ElementAt(currentans);
            //     }
            //     currentans++;
            // }
            // Shuffle(answers);
            // ansA = answers.ElementAt(0);
            // ansB = answers.ElementAt(1);
            // ansC = answers.ElementAt(2);
            // ansD = answers.ElementAt(3);
            // foreach(Button b in answers)
            // {
            //     if (b.Equals(correctAns))
            //     {
            //         correctNumb = answers.IndexOf(b);
            //     }
            // }
            // reader.Close();
            // conn.Close();
            toJson tJ = new toJson();
            List<Question> lq = new List<Question>();
            List<Answer> la = new List<Answer>();
            lq = tJ.serializeQuestions();
            la = tJ.serializeAnswers();
            Question currQ=null;
            foreach(Question q in lq)
            {
                if (q.Topic == scenario && q.Difficulty == currentQuestion)
                {
                    currQ = q;
                    Quest.Text = q.Description;
                    Question.Text = "Question" + currentQuestion;
                    break;
                }
            }
            int currentans = 0;
            foreach (Answer a in la)
            {
                if (a.QuestionId == currQ.QuestionId)
                {
                    answers.ElementAt(currentans).Text = a.Description;
                    if (a.IsCorrect==1)
                    {
                        correctAns = answers.ElementAt(currentans);
                    }
                    currentans++;
                }
            }
            Shuffle(answers);
            ansA = answers.ElementAt(0);
            ansB = answers.ElementAt(1);
            ansC = answers.ElementAt(2);
            ansD = answers.ElementAt(3);
            foreach (Button b in answers)
            {
                if (b.Equals(correctAns))
                {
                    correctNumb = answers.IndexOf(b);
                }
            }

        }
        Button currButton;
        private void Check(object sender, EventArgs e)
        {
            ds.playSimpleSound(Properties.Resources.tiditi);
            Button b = sender as Button;
            currButton = b;
            currButton.BackColor = Color.Orange;
            foreach (Button b2 in answers)
            {
                b2.Enabled = false;
            }
            Timer t = new Timer();
            t.Interval = 300;
            t.Tick += timerTick;
            tick = 0;
            t.Start();
        }
        private int tick = 0;
        private void timerTick(object sender, EventArgs e)
        {
            tick++;
            if (tick == 10)
            {
                if (currButton.Equals(correctAns))
                {
                    ds.playSimpleSound(Properties.Resources.dobrze);
                    currButton.BackColor = Color.Green;
                    switch (currentQuestion)
                    {
                        case 1:
                            pictureBox1.BackgroundImage = Properties.Resources.tabela1;
                            break;
                        case 2:
                            pictureBox1.BackgroundImage = Properties.Resources.tabela2;
                            break;
                        case 3:
                            pictureBox1.BackgroundImage = Properties.Resources.tabela3;
                            break;
                        case 4:
                            pictureBox1.BackgroundImage = Properties.Resources.tabela4;
                            break;
                        case 5:
                            pictureBox1.BackgroundImage = Properties.Resources.tabela5;
                            break;
                        case 6:
                            pictureBox1.BackgroundImage = Properties.Resources.tabela6;
                            break;
                        case 7:
                            pictureBox1.BackgroundImage = Properties.Resources.tabela7;
                            break;
                        case 8:
                            pictureBox1.BackgroundImage = Properties.Resources.tabela8;
                            break;
                        case 9:
                            pictureBox1.BackgroundImage = Properties.Resources.tabela9;
                            break;
                        case 10:
                            pictureBox1.BackgroundImage = Properties.Resources.tabela10;
                            break;
                        case 11:
                            pictureBox1.BackgroundImage = Properties.Resources.tabela11;
                            break;
                        case 12:
                            pictureBox1.BackgroundImage = Properties.Resources.tabela12;
                            PlayerWon = true;
                            break;
                    }
                }
                else
                {
                    ds.playSimpleSound(Properties.Resources.zle);
                    currButton.BackColor = Color.Red;                  
                    GameOver = true;
                }
            }
            else if (tick == 16)
            {
                Timer t = sender as Timer;
                t.Stop();
                if (PlayerWon)
                {
                    Win w = new Win(this);
                    w.ShowDialog();                   
                }
                if (GameOver)
                {
                    End en = new End(this);
                    en.ShowDialog();
                }
                else
                {
                    currentQuestion++;
                    loadNewQuestion();
                }
                foreach (Button b in answers)
                {
                    b.BackColor = Color.Wheat;
                }
                
                foreach (Button b2 in answers)
                {
                    b2.Enabled = true;
                }
                
            }
            else if (tick < 10 && tick % 2 == 0)
            {
                currButton.BackColor = Color.Wheat;
            }
            else if (tick < 10 && tick % 2 != 0)
            {
                currButton.BackColor = Color.Orange;
            }

        }


        private void pictureBox3_Click(object sender, EventArgs e)
        {
            phone p = new phone();
            p.ShowDialog();
            PictureBox p2 = sender as PictureBox;
            p2.BackgroundImage = Properties.Resources.kolo3used;
            p2.Enabled = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int rnd = r.Next(4);
            while (rnd == answers.IndexOf(correctAns))
            {
                rnd = r.Next(4);
            }         
            foreach(Button b in answers)
            {
                if (!b.Equals(correctAns) && !b.Equals(answers.ElementAt(rnd)))
                {
                    b.BackColor = Color.Gray;
                    b.Enabled = false;
                }
            }
            PictureBox p = sender as PictureBox;
            p.BackgroundImage = Properties.Resources.kolo1used;
            p.Enabled = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            wykresy w = new wykresy(correctNumb);
            w.ShowDialog();
            PictureBox p = sender as PictureBox;
            p.BackgroundImage = Properties.Resources.kolo2used;
            p.Enabled = false;
        }
        private TForm getForm<TForm>()where TForm : Form
        {
            return (TForm)Application.OpenForms.OfType<TForm>().FirstOrDefault();
        }

        private void OnClose(object sender, FormClosedEventArgs e)
        {
            Form f = getForm<Form1>();
            f.Close();
        }
        public void Shuffle(List<Button> list)
        {
            Random rng = new Random();
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                var value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}
