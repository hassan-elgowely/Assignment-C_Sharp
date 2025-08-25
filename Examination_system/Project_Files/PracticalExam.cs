using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_system.Project_Files
{
    internal class PracticalExam : Exam
    {
        public PracticalExam(int _Time, int _NumOfQuestion, List<Question> list) : base(_Time, _NumOfQuestion, list)
        {

        }

        public override void EnterExamDetails()
        {
            base.EnterExamDetails();

            for (int i = 0;i < NumOfQuestion;i++)
            {
                var q = new MCQ("MCQ", 0, 0, new List<Answer>(), 0);
                q.EnterQuestion();
                Questions.Add(q);
            }
        }

        public override void ShowExam()
        {
            int Grade = 0;
            for (int i = 0; i < Questions.Count; i++)
            {
                Console.WriteLine($"{Questions[i].Header}\n(Q{i + 1}) {Questions[i].Body}");
     
                Console.WriteLine($"Your Answer : {GetAnswerTextById(Questions[i].Answers, Questions[i].UserAnswerId)}");
                Console.WriteLine($"Right Answer : {GetAnswerTextById(Questions[i].Answers, Questions[i].RightAnswerId)}");
                
                if (Questions[i].UserAnswerId.CompareTo(Questions[i].RightAnswerId) == 0)
                {
                    Grade += Questions[i].Mark;
                }
                
            }
            Console.WriteLine($"Your Grade : {Grade}");
        }

        public override void StartExam()
        {
            base.StartExam();

            foreach (var item in Questions)
            {
                Console.WriteLine($"{item.Header}\nQ) {item.Body}");
                foreach (var chooses in item.Answers)
                    Console.WriteLine($"{chooses.AnswerId}- {chooses.AnswerText} ");
                int useranswerid;
                do
                {
                    Console.Write("Enter Answer Id : ");
                } while (!(int.TryParse(Console.ReadLine(), out useranswerid)&& (useranswerid == 1 || useranswerid == 2 || useranswerid == 3)));

                item.UserAnswerId = useranswerid;
            }
        }
        
    }
}
