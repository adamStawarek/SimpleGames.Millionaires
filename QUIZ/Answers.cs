using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUIZ
{

    public class Answers
    {
        public List<Answer> answersArray { get; set; }
    }

    public class Answer
    {
        public int AnswerId { get; set; }
        public int QuestionId { get; set; }
        public string Description { get; set; }
        public int IsCorrect { get; set; }
    }

}
