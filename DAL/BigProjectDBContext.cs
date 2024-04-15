using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BigProjectDBContext : DbContext
    {
        public BigProjectDBContext(DbContextOptions<BigProjectDBContext> options) : base(options)
        {

        }
        public required DbSet<Author> Authors { get; set; }
        public required DbSet<Book> Books { get; set; }
        public required DbSet<Category> Categories { get; set; }

    }
}
