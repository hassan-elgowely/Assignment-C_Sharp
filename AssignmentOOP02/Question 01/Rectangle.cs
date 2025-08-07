using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP02.Question_01
{
    internal class Rectangle : IRectangle
    {
        public decimal Area { get ; set ; }
        public decimal Length { get ; set; }
        public decimal Width { get ; set; }

        public void DisplayShapeInfo()
        {
            Area = Length * Width;
            Console.WriteLine($"Rectangle Area : {Area} ");
        }
    }
}
