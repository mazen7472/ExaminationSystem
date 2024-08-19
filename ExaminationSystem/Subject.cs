using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    class Subject : ExamBase
    {

        public ExamBase examSubject { get; set; }
        public QuestionBase[] questionSubject { get; set; }

        public List<QuestionBase> questionList = new List<QuestionBase>();

        public List<Answer> answerList = new List<Answer>();

        public List<MCQQuestion> mcqQuestions = new List<MCQQuestion>();
        public int SubId { get; set; }
        public string SubName { get; set; }



        public Subject(int _subId, string _subName)
        {
            SubId = _subId;
            SubName = _subName;
        }

        public override string ToString()
        {
            return $"Subject ID: {SubId}\nSubject Name: {SubName}";
        }
       

        public void CreateExam()
        {

            bool flag;
            int typeOfExam;
            int TypeOfQuestion;

            do
            {
                Console.Write("Please Enter The Type You Want To Create ( 1 For Practical and 2 For final ): ");
                flag = int.TryParse(Console.ReadLine(), out typeOfExam);
            } while (!flag || (typeOfExam != 1 && typeOfExam != 2));




            int timeOfExam;
            do
            {
                Console.Write("Please Enter The Time Of Exam In Minutes: ");
                flag = int.TryParse(Console.ReadLine(), out timeOfExam);
            } while (!flag || timeOfExam <= 0);

            int NumberOfQuestion;
            do
            {
                Console.Write("Please Enter The Number Of Questions You Want To Create: ");
                flag = int.TryParse(Console.ReadLine(), out NumberOfQuestion);
            } while (!flag || NumberOfQuestion <= 0);
            int NumOfQuestions = NumberOfQuestion;

            if (typeOfExam == 1)
            {
                PracticalExam p = new PracticalExam();

            }
            else if (typeOfExam == 2)
            {
                FinalExam f = new FinalExam();

            }

            ExamBase exam = new ExamBase(timeOfExam, NumberOfQuestions);


            QuestionBase[] questions = new QuestionBase[NumOfQuestions];
            Answer[] answers = new Answer[NumOfQuestions];
            MCQQuestion[] mcq = new MCQQuestion[NumOfQuestions];
            Console.Clear();


            if (typeOfExam == 1)
            {
                for (int i = 0; i < NumOfQuestions; i++)
                {
                    questions[i] = new QuestionBase();
                    answers[i] = new Answer();
                    mcq[i] = new MCQQuestion();
                    Console.WriteLine("Choose One Answer Question");
                    questions[i].Header = "Choose One Answer Question";
                    

                    do
                    {
                        Console.WriteLine("Please Enter The Body Of The Question: ");
                        questions[i].Body = Console.ReadLine();
                    } while (string.IsNullOrEmpty(questions[i].Body));
                    int marks;
                    do
                    {
                        Console.WriteLine("Please Enter The Marks Of The Question: ");
                        flag = int.TryParse(Console.ReadLine(), out marks);
                    } while (!flag || marks <= 0);
                    questions[i].Mark = marks;
                    Grade += questions[i].Mark;

                    Console.WriteLine("The Choices For Question: ");

                    do
                    {
                        Console.Write("Please Enter The Choice Number 1: ");
                        mcq[i].choices[0] = Console.ReadLine();
                    } while (mcq[i].choices[0] == string.Empty);

                    do
                    {
                        Console.Write("Please Enter The Choice Number 2: ");
                        mcq[i].choices[1] = Console.ReadLine();
                    } while (mcq[i].choices[1] == string.Empty);

                    do
                    {
                        Console.Write("Please Enter The Choice Number 3: ");
                        mcq[i].choices[2] = Console.ReadLine();
                    } while (mcq[i].choices[2] == string.Empty);


                    int correctChoice;
                    do
                    {
                        Console.WriteLine("Please Spicify The Right Choice Of The Question: ");
                        flag = int.TryParse(Console.ReadLine(), out correctChoice);
                    } while (!flag || (correctChoice != 1 && correctChoice != 2 && correctChoice != 3));
                    mcq[i].rightChoice = correctChoice;
                    answers[i].AnswerText = correctChoice.ToString();
                    answers[i].AnswerId = i;
                    Console.Clear();

                    answerList.Add(answers[i]);
                    questionList.Add(questions[i]);
                    mcqQuestions.Add(mcq[i]);
                }


            }
            else if (typeOfExam == 2)
            {
                for (int i = 0; i < NumOfQuestions; i++)
                {
                    questions[i] = new QuestionBase();
                    answers[i] = new Answer();
                    mcq[i] = new MCQQuestion();


                    Console.Clear();
                    do
                    {
                        Console.Write($"Please Choose The Type Of Question Number ({i + 1}) ( 1 For True | False and 2 For MCQ ): ");
                        flag = int.TryParse(Console.ReadLine(), out TypeOfQuestion);
                    } while (!flag || (TypeOfQuestion != 1 && TypeOfQuestion != 2));
                    Console.Clear();

                    if (TypeOfQuestion == 1)
                    {
                        TFQuestion TF = new TFQuestion();
                        Console.WriteLine("True | False Question");
                        TF.TFAnswer = new bool[1];
                        questions[i].Header = "True | False Question";

                        do
                        {
                            Console.WriteLine("Please Enter The Body Of The Question: ");
                            questions[i].Body = Console.ReadLine();
                        } while (string.IsNullOrEmpty(questions[i].Body));

                        int marks;
                        do
                        {
                            Console.WriteLine("Please Enter The Marks Of The Question: ");
                            flag = int.TryParse(Console.ReadLine(), out marks);
                        } while (!flag || marks <= 0);
                        questions[i].Mark = marks;
                        Grade += questions[i].Mark;

                        int correctAnswer;
                        do
                        {
                            Console.WriteLine("Please Enter The Right Answer Of The Question ( 1 For True And 2 For False ): ");
                            flag = int.TryParse(Console.ReadLine(), out correctAnswer);
                        } while (!flag || (correctAnswer != 1 && correctAnswer != 2));

                        if (correctAnswer == 1)
                        {
                            answers[i].AnswerText = "True";
                            answers[i].AnswerId = i;


                        }
                        else if (correctAnswer == 2)
                        {
                            answers[i].AnswerText = "False";
                            answers[i].AnswerId = i;
                        }

                        answerList.Add(answers[i]);
                        questionList.Add(questions[i]);
                        mcqQuestions.Add(mcq[i]);
                    }

                    else if (TypeOfQuestion == 2)
                    {

                        Console.WriteLine("Choose One Answer Question");
                        questions[i].Header = "Choose One Answer Question";

                        do
                        {
                            Console.WriteLine("Please Enter The Body Of The Question: ");
                            questions[i].Body = Console.ReadLine();
                        } while (string.IsNullOrEmpty(questions[i].Body));
                        int marks;
                        do
                        {
                            Console.WriteLine("Please Enter The Marks Of The Question: ");
                            flag = int.TryParse(Console.ReadLine(), out marks);
                        } while (!flag || marks <= 0);
                        questions[i].Mark = marks;
                        Grade += questions[i].Mark;

                        Console.WriteLine("The Choices For Question: ");

                        do
                        {
                            Console.Write("Please Enter The Choice Number 1: ");
                            mcq[i].choices[0] = Console.ReadLine();
                        } while (string.IsNullOrEmpty(mcq[i].choices[0]));

                        do
                        {
                            Console.Write("Please Enter The Choice Number 2: ");
                            mcq[i].choices[1] = Console.ReadLine();
                        } while (string.IsNullOrEmpty(mcq[i].choices[1]));

                        do
                        {
                            Console.Write("Please Enter The Choice Number 3: ");
                            mcq[i].choices[2] = Console.ReadLine();
                        } while (string.IsNullOrEmpty(mcq[i].choices[2]));


                        int correctChoice;
                        do
                        {
                            Console.WriteLine("Please Spicify The Right Choice Of The Question: ");
                            flag = int.TryParse(Console.ReadLine(), out correctChoice);
                        } while (!flag || (correctChoice != 1 && correctChoice != 2 && correctChoice != 3));
                        mcq[i].rightChoice = correctChoice;
                        answers[i].AnswerText = correctChoice.ToString();
                        answers[i].AnswerId = i;

                        answerList.Add(answers[i]);
                        questionList.Add(questions[i]);
                        mcqQuestions.Add(mcq[i]);
                    }
                }
            }




        }
    
        
        public  void ShowExam()
        {
            Console.Clear();
            int[] studentAnswer = new int[questionList.Count];
            int studentGrade = 0;

            for (int i = 0; i < questionList.Count; i++)
            {

                Console.WriteLine($"{questionList[i].Header}\t( {questionList[i].Mark} )");
                Console.WriteLine(questionList[i].Body);
                bool flag = false;

                if (questionList[i].Header == "True | False Question")
                {
                    Console.WriteLine("1. True\t\t2. False");
                    do
                    {
                        flag = int.TryParse(Console.ReadLine(), out studentAnswer[i]);
                    } while (!flag || (studentAnswer[i] != 1 && studentAnswer[i] != 2));

                    if (studentAnswer[i].ToString() == answerList[i].AnswerText)
                    {
                        studentGrade += questionList[i].Mark;
                    }
                    
                }

                else if (questionList[i].Header == "Choose One Answer Question")
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write($"{j + 1}. {mcqQuestions[i].choices[j]}\t\t");
                    }

                    Console.WriteLine();

                    do
                    {
                        flag = int.TryParse(Console.ReadLine(), out studentAnswer[i]);
                    } while (!flag || (studentAnswer[i] != 1 && studentAnswer[i] != 2 && studentAnswer[i] != 3));

                    if (studentAnswer[i].ToString() == answerList[i].AnswerText)
                    {
                        studentGrade += questionList[i].Mark;
                    }
                    
                }

            }

            Console.Clear();
            Console.WriteLine("Your Answers:");
            for (int i = 0; i < questionList.Count; i++)
            {
                Console.WriteLine($"Q{i + 1}) {questionList[i].Body}: {studentAnswer[i]}");
                Console.WriteLine($"The Right Answer For Question {answerList[i].AnswerId + 1}: {answerList[i].AnswerText}");
                Console.WriteLine();
            }
            Console.WriteLine($"Your Exam Grade Is {studentGrade} out of {Grade}");

        }

       









    }
    
}
