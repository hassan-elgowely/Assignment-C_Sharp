using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_system.Project_Files
{
    abstract class Exam
    {
        public int Time { get; set; }
        public int NumOfQuestion { get; set; }
        public List<Question> Questions { get; set; }

        public Exam(int _Time, int _NumOfQuestion, List<Question> list)
        {
            Time = _Time;
            NumOfQuestion = _NumOfQuestion;
            Questions = list;
        }

        public virtual void EnterExamDetails()
        {
            int timeinput, numquestion;
            do
            {
                Console.Write("Enter Time Of Exam [30 Min To 180 Min ] : ");
            } while (!(int.TryParse(Console.ReadLine(), out timeinput) && (timeinput >= 30 && timeinput <= 180)));
            Time = timeinput;

            do
            {
                Console.Write("Enter Number Of Question : ");
            } while (!(int.TryParse(Console.ReadLine(), out numquestion) && (numquestion > 0)));
            NumOfQuestion = numquestion;

        }

        public abstract void ShowExam();

        public virtual void StartExam()
        {
            
            Console.WriteLine($"Time: {Time} Min\nNumber Of Question: {NumOfQuestion}");
        }
        
        public static string GetAnswerTextById(List<Answer> Answers, int id)
        {
            if (Answers is not null)
            {
                foreach (var item in Answers)
                {
                    if (item.AnswerId == id)
                        return item.AnswerText!;
                } 
            }
            return "Not Found";
        }
        
    }
}
