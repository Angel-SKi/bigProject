using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Book
    {
        public int Id { get; set; } 
        public required string Title { get; set; }
        public int AuthorId { get; set; }
        public required Author Author { get; set; }
        public List<Category> Categories { get; } = [];

    }
}
