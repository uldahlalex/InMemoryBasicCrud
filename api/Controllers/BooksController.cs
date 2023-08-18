using Microsoft.AspNetCore.Mvc;
using service;

namespace api.Controllers;

[ApiController]
public class BooksController : ControllerBase
{

    private BookService _bookService;

    public BooksController(BookService bookService)
    {
        _bookService = bookService;
    }

    [HttpGet]
    [Route("/books")]
    public object GetAll()
    {
        return new
        {
            Message = "These are all the books:",
            Books = _bookService.GetBooks()
        };
    }

    [HttpPost]
    [Route("/books")]
    public object Post([FromBody] Book book)
    {
        _bookService.AddBook(book);
        return "Book has been added";
    }
}
