using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    class MCQQuestion : QuestionBase
    {
        public string[] choices = new string[4];
        public int rightChoice { get; set; }

        public MCQQuestion() { }
        public MCQQuestion(string header, string body, int mark, List<Answer> answerList, int rightAnswer) : base(header, body, mark, answerList, rightAnswer)
        {
        }

    } 
}




