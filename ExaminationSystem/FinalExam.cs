using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    class FinalExam : ExamBase
    {
        public TFQuestion[] TFQuestions { get; set; }

        public MCQQuestion[] MCQQuestions { get; set; }

        public FinalExam()
        {
           

        }
        public FinalExam(int timeOfExam, int numberOfQuestions) : base(timeOfExam, numberOfQuestions)
        {
            
        }




    }
}
