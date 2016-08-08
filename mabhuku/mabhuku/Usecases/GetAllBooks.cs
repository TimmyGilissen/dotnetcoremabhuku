using System.Collections.Generic;
using System.Linq;
using mabhuku.Domain;
using mabhuku.Dto;
using mabhuku.Mappers;
using mabhuku.Repositories;

namespace mabhuku.Usecases
{
  public class GetAllBooks
  {
    private readonly BookRepository _bookRepository;

    public GetAllBooks()
    {
      _bookRepository = new BookRepository();
    }

    public List<BookDto> Execute()
    {
      var books = _bookRepository.GetAll();

      return books.Select(Mapper.MapToBookDto).ToList();
    }


  }
}