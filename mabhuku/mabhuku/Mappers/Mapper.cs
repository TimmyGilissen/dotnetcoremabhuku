using mabhuku.Domain;
using mabhuku.Dto;
using mabhuku.Models;

namespace mabhuku.Mappers
{
  public class Mapper
  {
    public static BookModel MapToBookModel(BookDto book)
    {
      return new BookModel
      {
        Author = book.Author,
        Description = book.Description,
        Id = book.Id,
        Link = book.Link,
        Title = book.Title
      };
    }

    public static BookDto MapToBookDto(Book book)
    {
      return new BookDto
      {
        Title = book.Title,
        Author = book.Author,
        Description = book.Description,
        Link = book.Link,
        Id = book.BookId
      };
    }
  }
}