using BLL.Models;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IBookService
    {
        public Book GetBookById(int id);
        public List<Book> GetAllBooks();
        public void DeleteBook(int id);
        public void InsertBook(Book entity);
        public void UpdateBook(Book entity);
    }
}
