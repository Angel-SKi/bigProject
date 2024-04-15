using AutoMapper;
using BLL.Interfaces;
using DAL.Entities;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace PL.Controllers
{
    public class AuthorController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IAuthorService _authorService;

        public AuthorController(IAuthorService authorService, IMapper mapper)
        {
            _mapper = mapper;
            _authorService = authorService;
        }

        [HttpPost("InsertAuthor")]
        public Author InsertAuthor([FromBody] Author author)
        {
            _authorService.InsertAuthor(author);

            return author;
        }

        [HttpPut]
        [Route("UpdateAuthor")]
        public Author UpdateAuthor([FromBody] Author author)
        {
            _authorService.UpdateAuthor(author);
            return author;
        }

        [HttpDelete]
        [Route("DeleteAuthor")]
        public void DeleteAuthor(int authorId)
        {
            _authorService.DeleteAuthor(authorId);
        }

        [HttpGet("GetAuthorById")]
        public Author GetAuthorById(int idAuthor) 
        {
            var author = _authorService.GetAuthorById(idAuthor);
            return author;  
        }

        [HttpGet("GetAllAuthors")]
        public List<Author> GetAllAuthors() 
        { 
            return _authorService.GetAllAuthors();
        }

    }
}
