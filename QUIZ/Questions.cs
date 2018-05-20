using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUIZ
{
    public class Questions
    {
        public List<Question> questionArray { get; set; }
    }

    public class Question
    {
        public int QuestionId { get; set; }
        public string Description { get; set; }
        public int Difficulty { get; set; }
        public string Topic { get; set; }
    }


}
