using System.Collections.Generic;
using System.Linq;
using mabhuku.DBContext;

namespace mabhuku.Repositories
{
    public class BookRepository
    {

      public List<Domain.Book> GetAll()
        {
            var result = new List<Domain.Book>();

            using(var db = new DatabaseContext()){
               result = db.Books.ToList();
            }        

            return result;
        }

        public void AddBook(Domain.Book book)
        {
            using(var db = new DatabaseContext()){

                db.Books.Add(new Domain.Book { Title = book.Title, Author = book.Author, Link = book.Link, Description = book.Description } );
                db.SaveChanges();
            }    
        }

      public Domain.Book GetBookWithId(int id)
      {
        Domain.Book result = null;

        using (var db = new DatabaseContext())
        {
          result = db.Books.First(x => x.BookId == id);
        }

        return result;
      }
    }
}