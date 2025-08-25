using Examination_system.Project_Files;

namespace Examination_system
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var subject = new Subject(1, "C#");
            subject.CreateExam();
        }
    }
}
