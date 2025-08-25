using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_system.Project_Files
{
    class MCQ : Question
    {
        public override string? Header   {  get;  } = "MCQ Question";

        public MCQ(string Body, int Mark , int RightAnswerId, List<Answer> list, int UserAnswerId) :base(Body, Mark, RightAnswerId, list, UserAnswerId) 
        {
            
        }

        public override void EnterQuestion()
        {
            do
            {
                Console.Write("Enter Question Body : ");
                Body = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(Body));
            int markinput;
            do
            {
                Console.Write("Enter Question Mark : ");
            } while (!(int.TryParse(Console.ReadLine(), out markinput)) || (markinput <= 0));
            Mark = markinput;
            Answers = new List<Answer>();
            string text;
            
            Console.WriteLine("Choices Of Question [You Have 3 Choices]");
            for (int i = 1; i <= 3; i++)
            {
                do
                {
                    Console.WriteLine($"Enter Choics Number {i}");
                    text = Console.ReadLine()!;
                    Answers.Add(new Answer(0, "") { AnswerId = i, AnswerText = text });
                } while (string.IsNullOrWhiteSpace(text));
            }
            int rightanswerid;
            do
            {
                Console.Write("Enter Right Answer Id : ");
            } while (!(int.TryParse(Console.ReadLine(), out rightanswerid)) || (!(rightanswerid == 1 || rightanswerid == 2 || rightanswerid == 3)));
            RightAnswerId = rightanswerid;
            
        }
    }
}
