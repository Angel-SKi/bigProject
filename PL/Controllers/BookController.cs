using AutoMapper;
using BLL.Interfaces;
using DAL.Entities;
using Microsoft.AspNetCore.Mvc;

namespace PL.Controllers
{
    public class BookController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IBookService _bookService;

        public BookController(IBookService bookService, IMapper mapper)
        {
            _mapper = mapper;
            _bookService = bookService;
        }

        [HttpPost("InsertBook")]
        public Book InsertBook([FromBody] Book book)
        {
            _bookService.InsertBook(book);

            return book;
        }

        [HttpPut]
        [Route("UpdateBook")]
        public Book UpdateBook([FromBody] Book book)
        {
            _bookService.UpdateBook(book);
            return book;
        }

        [HttpDelete]
        [Route("DeleteBook")]
        public void DeleteBook(int bookId)
        {
            _bookService.DeleteBook(bookId);
        }

        [HttpGet("GetBookById")]
        public Book GetAuthorById(int idBook)
        {
            var book = _bookService.GetBookById(idBook);
            return book;
        }

        [HttpGet("GetAllBooks")]
        public List<Book> GetAllBooks()
        {
            return _bookService.GetAllBooks();
        }
    }
}
