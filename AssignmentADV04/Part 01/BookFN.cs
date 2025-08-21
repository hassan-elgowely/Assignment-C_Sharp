using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentADV04.Part_01
{
    internal class BookFN
    {
        public static string GetTitle(Book b)
        { 
            return b.Title;
        }
        public static string GetAuthors(Book b)
        {
            return string.Join(",",b.Authors);
        }
        public static string GetPrice(Book b)
        {
            return b.Price.ToString();
        }
    }
}
