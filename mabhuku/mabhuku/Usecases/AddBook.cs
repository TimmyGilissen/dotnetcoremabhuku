using mabhuku.Commands;
using mabhuku.Domain;
using mabhuku.Repositories;

namespace mabhuku.Usecases
{
  public class AddBook
  {
    private readonly BookRepository _bookRepository;

    public AddBook()
    {
      _bookRepository = new BookRepository(	);
    }

    public void Execute(AddBookCommand addBookCommand)
    {
      _bookRepository.AddBook(new Book
      {
        Author = addBookCommand.Author,
        Description = addBookCommand.Description,
        Link = addBookCommand.Link,
        Title = addBookCommand.Title
      });
    }
  }
}