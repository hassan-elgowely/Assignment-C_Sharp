using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP02.Question_01
{
    internal class Circle : ICircle
    {
        public decimal Area { get ; set; }
        public decimal Diameter { get ; set ; }

        public void DisplayShapeInfo()
        {
            Area = 3.14M * Diameter * Diameter;
            Console.WriteLine($"Circle Area : {Area} ");
        }
    }
}
