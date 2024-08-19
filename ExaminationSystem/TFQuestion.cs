using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    class TFQuestion : QuestionBase
    {
        public bool TF { get; set; }
        public bool[] TFAnswer { get; set; }
        public TFQuestion() { }
        public TFQuestion(string header, string body, int mark, List<Answer> answerList, int rightAnswer) : base(header, body, mark, answerList, rightAnswer)
        {
        }

        
                    


             


            
    }
}

           

     

