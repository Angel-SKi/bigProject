using BLL.Models;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IAuthorService
    {
        public Author GetAuthorById(int id);
        public List<Author> GetAllAuthors();
        public void DeleteAuthor(int id);
        public void InsertAuthor(Author entity);
        public void UpdateAuthor(Author entity);
    }
}
