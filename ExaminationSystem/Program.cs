using System.Diagnostics;

namespace ExaminationSystem
{
  

    internal class Program
    {
       
        static void Main()
        {
            Subject sub1 = new Subject(1, "c#");
            sub1.CreateExam();
            Console.Clear();

            Console.WriteLine("Do you want to start the exam (y/n):");

            if (char.Parse(Console.ReadLine()) ==  ('y'))
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                sub1.ShowExam();
                Console.WriteLine($"The Elapsed Time = {stopwatch.Elapsed}");
            }
   

           


        }
    }
}
