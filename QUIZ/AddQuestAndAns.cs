using Newtonsoft.Json;
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
    public partial class AddQuestAndAns : Form
    {
        public AddQuestAndAns()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //get last QuestionId and AnswerId
            toJson tJ = new toJson();
            List<Question> lq = new List<Question>();
            List<Answer> la = new List<Answer>();
            int biggestIndex=0;
            int currentAnsIndex = 0;
            foreach(Question qq in lq)
            {
                if (biggestIndex <= qq.QuestionId)
                    biggestIndex = qq.QuestionId;
            }
            foreach (Answer a in la)
            {
                if (currentAnsIndex <= a.AnswerId)
                {
                    currentAnsIndex = a.AnswerId;
                }
            }

            Question q = new Question();
            q.Description = txtQuestion.Text;
            q.Difficulty = Int32.Parse(cmbDifficulty.Text);
            q.QuestionId = biggestIndex + 1;
            q.Topic = cmbScenario.Text;
            lq.Add(q);

            // Update json data string
            var question = JsonConvert.SerializeObject(lq);
            System.IO.File.WriteAllText("C:\\Users\\Administrator\\source\\repos\\QUIZ\\QUIZ\\questions.json", question);

            List<string> answers = new List<string>();
            List<Answer> newAnswers = new List<Answer>();
            answers.Add(txtAnsA.Text);
            answers.Add(txtAnsB.Text);
            answers.Add(txtAnsC.Text);
            answers.Add(txtAnsD.Text);
            foreach(string s in answers)
            {
                currentAnsIndex++;
                Answer a = new Answer();
                a.Description = s;
                a.QuestionId = q.QuestionId;
                a.IsCorrect = 0;
                a.AnswerId = currentAnsIndex;
                newAnswers.Add(a);
            }
            switch (cmbCorrect.Text)
            {
                case "AnsA":
                    newAnswers[0].IsCorrect = 1;
                    break;
                case "AnsB":
                    newAnswers[1].IsCorrect = 1;
                    break;
                case "AnsC":
                    newAnswers[2].IsCorrect = 1;
                    break;
                case "AnsD":
                    newAnswers[3].IsCorrect = 1;
                    break;
            }
            la.AddRange(newAnswers);
            // Update json data string
            var ans= JsonConvert.SerializeObject(la);
            System.IO.File.WriteAllText("C:\\Users\\Administrator\\source\\repos\\QUIZ\\QUIZ\\ans.json", ans);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
