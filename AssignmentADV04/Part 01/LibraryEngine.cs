using AssignmentADV04.Part_01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AssignmentADV04.Part_01
{ 
    internal class LibraryEngine
    {
        public static void ProcessBooks (List<Book> blist , DelegateParameters Dbook) 
        {
            foreach (var B in blist)
                Console.WriteLine(Dbook(B));
        }
    }
    internal class LibraryEngineBuildINDelegate
    {
        public static void ProcessBooks(List<Book> blist, Func<Book,string> Dbook)
        {
            foreach (var B in blist)
                Console.WriteLine(Dbook(B));
        }
    }
}
