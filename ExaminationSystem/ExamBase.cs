using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ExaminationSystem
{
    public  class ExamBase : IComparable ,ICloneable
    {
       

       
        public int TimeOfExam { get; set; }
        public int NumberOfQuestions { get; set; }
        public int Grade { get; set; }
        

        public ExamBase()
        {
          


        }


        public ExamBase(int timeOfExam, int numberOfQuestions )
        {
            TimeOfExam = timeOfExam;
            NumberOfQuestions = numberOfQuestions;
            



        }
        public ExamBase(ExamBase exam) 
        {
            TimeOfExam = exam.TimeOfExam;
            NumberOfQuestions = exam.NumberOfQuestions;
            Grade = exam.Grade;

        }

        public int CompareTo(object? obj)
        {
            ExamBase Right = obj as ExamBase;
            if (Grade > Right.Grade)
            {
                return 1;
            }
            else if (Grade < Right.Grade)
            { 
                return -1;
            }

            return 0;
            
        }
        public object Clone()
        {
            return new ExamBase(this);
        }






    }
}
