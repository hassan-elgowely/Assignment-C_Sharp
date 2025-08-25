using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_system.Project_Files
{
    abstract class Question 
    {
        public abstract string? Header { get; }
        public string? Body { get; set; }
        public int Mark { get; set; }
        public int RightAnswerId { get; set; }
        public int UserAnswerId { get; set; }
        public List<Answer> Answers { get; set; }

        protected Question(string _Body , int _Mark , int _RightAnswerId , List<Answer> list, int _UserAnswerId)
        {
            Body = _Body;
            Mark = _Mark;
            RightAnswerId = _RightAnswerId;
            Answers = list;
            UserAnswerId = _UserAnswerId;
        }
        public abstract void EnterQuestion();

        
    }
}
