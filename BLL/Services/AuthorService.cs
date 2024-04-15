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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace BLL.Services
{
    public class AuthorService : IAuthorService
    {
        private readonly IMapper _mapper;
        private readonly IAuthorRepository _authorRepository;

        public AuthorService(IAuthorRepository authorRepository, IMapper mapper)
        {
            _authorRepository = authorRepository;
            _mapper = mapper;
        }

        public void DeleteAuthor(int id)
        {
            _authorRepository.Delete(id);
        }

        public List<Author> GetAllAuthors()
        {
            var query = _authorRepository.GetAll();
            var authors = query.ToList();
            return authors;
        }

        public Author GetAuthorById(int id)
        {
            var query = _authorRepository.GetAll();
            var authorEntity = query.FirstOrDefault(author => author.Id == id);

            if (authorEntity == null)
            {
                throw new InvalidOperationException("No Author found.");
            }
            return authorEntity;
        }

        
        
        public void InsertAuthor(Author entity)
        {
            if (entity == null) throw new ArgumentNullException("Author cannot be null.");
            _authorRepository.Create(entity);
        }

        
        public void UpdateAuthor(Author entity)
        {
            _authorRepository.Update(entity);
            
        }
    }
}
