using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    class QuestionBase
    {


        public string Header { get; set; }
        public string Body { get; set; }
        public int Mark { get; set; }
        public List<Answer> AnswerList { get; set; }
        public int RightAnswer { get; set; }

        public QuestionBase()
        {

        }

        public QuestionBase(string header, string body, int mark, List<Answer> answer, int rightAnswer)
        {
            Header = header;
            Body = body;
            Mark = mark;
            AnswerList = answer;
            RightAnswer = rightAnswer;

        }
        public override string ToString()
        {
            return $"Header: {Header}\nBody: {Body}\nMark: {Mark}\nRightAnswer: {RightAnswer}";
        }
    }
    

   
}
