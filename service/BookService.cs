namespace service;
public class BookService
{

    private List<Book> Books = new List<Book>();


    public void AddBook(Book book)
    {
        Books.Add(book);
    }

    public List<Book> GetBooks()
    {
        return Books;
    }
}
