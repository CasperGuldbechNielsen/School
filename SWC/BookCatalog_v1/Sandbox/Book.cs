namespace Sandbox
{
    class Book
    {
        private string isbn;
        private string title;
        private string author;
        private int noOfPages;

        public Book(string isbn, string title, string author, int noOfPages)
        {
            this.isbn = isbn;
            this.title = title;
            this.author = author;
            this.noOfPages = noOfPages;
        }

        public string GetISBN()
        {
            return isbn;
        }

        public string GetAllInformation()
        {
            string message = "ISBN: " + isbn + ", \"" + title + "\", by " + author + " ("+ noOfPages + " pages)";
            return message;
        }
    }
}
