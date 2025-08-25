using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_system.Project_Files
{
    internal class TrueFalse : Question
    {
        public override string? Header { get; } =  "True Or False Question";

        public TrueFalse(string Body, int Mark , int RightAnswerId, List<Answer> list, int UserAnswerId) : base(Body, Mark, RightAnswerId, list, UserAnswerId)
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
            int rightanswerid;
            do
            {
                Console.Write("Enter Right Answer Id [1 for True | 2 for False]: ");
            } while (!(int.TryParse(Console.ReadLine(), out rightanswerid)) || (!(rightanswerid == 1 || rightanswerid == 2)));
            RightAnswerId = rightanswerid;
            Answers = new List<Answer>()
            {
                new Answer(0,"") { AnswerId = 1, AnswerText = "True" },
                new Answer(0,"") { AnswerId = 2, AnswerText = "False" }
            };

        }
    }
}
