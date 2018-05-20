using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace QUIZ
{
    public class toJson
    {
        public List<Question> serializeQuestions()
        {
            Questions q = new Questions();
             q.questionArray = JsonConvert.DeserializeObject<List<Question>>(File.ReadAllText("C:\\Users\\Administrator\\source\\repos\\QUIZ\\QUIZ\\questions.json"));
            return q.questionArray;
        }
        public List<Answer> serializeAnswers()
        {
            Answers a = new Answers();
            a.answersArray= JsonConvert.DeserializeObject<List<Answer>>(File.ReadAllText("C:\\Users\\Administrator\\source\\repos\\QUIZ\\QUIZ\\ans.json"));
            return a.answersArray;
        }
       
    }
}
