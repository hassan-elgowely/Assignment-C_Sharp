using AssignmentADV04.Part_01;
namespace AssignmentADV04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>()
            {
                new Book( "1122", "C#Basice", new[] { "Ahmed", "Mohamed", "Omer" }, new DateTime (2010,1,1), 300),
                new Book( "3344", "C#OOP", new[] { "Ahmed", "Mohamed", "Omer" }, new DateTime (2011,1,1), 400),
                new Book( "2233", "C#ADV", new[] { "Ahmed", "Mohamed", "Omer" }, new DateTime (2012,1,1), 600)
            };

            //A
            LibraryEngine.ProcessBooks(books, BookFN.GetTitle);
            LibraryEngine.ProcessBooks(books, BookFN.GetAuthors);
            LibraryEngine.ProcessBooks(books, BookFN.GetPrice);

            //B
            Func<Book, string> funcTitle = BookFN.GetTitle;
            LibraryEngineBuildINDelegate.ProcessBooks(books, funcTitle);
            Func<Book, string> funcAuthors = BookFN.GetAuthors;
            LibraryEngineBuildINDelegate.ProcessBooks(books, funcAuthors);
            Func<Book, string> funcPrice = BookFN.GetPrice;
            LibraryEngineBuildINDelegate.ProcessBooks(books, funcPrice);

            //C
            Func<Book, string> funcISBN = delegate (Book b) { return b.ISBN; };
            LibraryEngineBuildINDelegate.ProcessBooks(books, funcISBN);

            //D
            Func<Book, string> funcPublicationDate = b => b.PublicationDate.ToString();
            LibraryEngineBuildINDelegate.ProcessBooks(books, funcPublicationDate);

        }
    }
}
