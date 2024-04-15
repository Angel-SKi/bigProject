using AutoMapper;
using BLL.Interfaces;
using BLL.Models;
using DAL.Entities;
using DAL.Interfaces;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class BookService : IBookService
    {
        private readonly IMapper _mapper;
        private readonly IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository, IMapper mapper)
        {
            _bookRepository = bookRepository;
            _mapper = mapper;
        }
        public void DeleteBook(int id)
        {
            _bookRepository.Delete(id);
        }

        public List<Book> GetAllBooks()
        {
            var query = _bookRepository.GetAll();
            var books = query.ToList();
            return books;
        }

        public Book GetBookById(int id)
        {
            var query = _bookRepository.GetAll();
            var bookEntity = query.FirstOrDefault(book => book.Id == id);

            if (bookEntity == null)
            {
                throw new InvalidOperationException("No Author found.");
            }
            return bookEntity;
        }

        public void InsertBook(Book entity)
        {
            if (entity == null) throw new ArgumentNullException("Book cannot be null.");
            _bookRepository.Create(entity);
        }

        public void UpdateBook(Book entity)
        {
            _bookRepository.Update(entity);
            
        }
    }
}
