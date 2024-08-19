using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    class PracticalExam : ExamBase
    {


      

        public MCQQuestion[] MCQQuestions { get; set; }
        public PracticalExam() { }
        public PracticalExam(int timeOfExam, int numberOfQuestions) : base(timeOfExam, numberOfQuestions)
          
        {
            
        }



  

      






     


    }
}
