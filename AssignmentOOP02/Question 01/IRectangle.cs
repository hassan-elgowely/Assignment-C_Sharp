using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP02.Question_01
{
    internal interface IRectangle : IShape
    {
        public decimal Length { get; set; }
        public decimal Width { get; set; }
    }
}
