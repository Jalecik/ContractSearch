using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace databaseFirst
{
    class Program
    {
        static void Main(string[] args)
        {using (var db = new BookDataEntities())
            {
                var book = new Book()
                {
                    id = 12,
                    name = "ghhgfhg",
                    price = 54,
                    cover = "gghhg",
                    author = "jjhkjh"
                };
                db.Books.Add(book);
                db.SaveChanges();
                Console.WriteLine("saved");
                Console.ReadLine();
            }
        }
    }
}
