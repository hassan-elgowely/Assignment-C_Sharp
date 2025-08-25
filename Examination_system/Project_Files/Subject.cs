using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_system.Project_Files
{
    class Subject
    {
        public int SubjectId { get; set; }
        public string? SubjectName { get; set; }
        public Exam exam { get; set; }

        public Subject(int _SubjectId, string _SubjectName)
        {
            SubjectId = _SubjectId;
            SubjectName = _SubjectName;
        }

        public void CreateExam()
        {
            Stopwatch sw = Stopwatch.StartNew();
            int n;
            do
            {
                Console.Write("Enter The Type Of Exam [1 for Practical | 2 for Final] : ");
            } while (!(int.TryParse(Console.ReadLine(), out n) && (n == 1 || n == 2)));
            if (n == 1)
            {
                exam = new PracticalExam(0,0,new List<Question>());
                exam.EnterExamDetails();
            }
            else if (n == 2)
            {
                exam = new FinalExam(0, 0, new List<Question>());
                exam.EnterExamDetails();
            }
            Console.Clear();
            
            char yesno;
            do
            {
                Console.Write("Do You want to Start Exam [Y | N] : ");
            } while (!(char.TryParse(Console.ReadLine(),out yesno) && (yesno == 'Y' || yesno == 'y' || yesno == 'N' || yesno == 'n'))) ;
            
            if (yesno == 'N' || yesno == 'n')
            {
                Console.Clear();
                Environment.Exit(0);
            }
            else if (yesno == 'Y' || yesno == 'y')
            {
                Console.Clear();
                sw.Start();
                exam.StartExam();
                sw.Stop();
                Console.Clear();
                exam.ShowExam();
                Console.WriteLine($"Time {sw}");
                Console.WriteLine("Thank You");
            }
        }

    }
}
