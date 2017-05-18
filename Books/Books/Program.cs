using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public class Book
        {
        public int Id { get; set; }
            public string Title { get; set; }
            public string PublishDate { get; set; }
            public int Price { get; set; }
            public string Language { get; set; }
            public string Publisher { get; set; }
            public string Genre { get; set; }
            public string EditionAmount { get; set; }
            public int AuthorId { get; set; }
            public Author Authors { get; set; }
        }
        public class Author
        {
        public int Id { get; set; }
            public string AuthorName { get; set; }
            public string Email { get; set; }
            public virtual List<Book> Books { get; set; }

            public Author()
            {
                this.Books = new List<Book>();
            }
        }
        public class BookStoreContext : DbContext
        {
            public BookStoreContext() : base("name=BookStoreContext")
            {

            }

            public DbSet<Book> Students { get; set; }
            public DbSet<Author> Subjects { get; set; }

            protected override void OnModelCreating(DbModelBuilder modelBuilder)
            {
                modelBuilder.Configurations.Add(new BookMapping());
                modelBuilder.Configurations.Add(new AuthorMapping());
            }
        }
    }
    }
    

