using mabhuku.Dto;
using mabhuku.Mappers;
using mabhuku.Repositories;

namespace mabhuku.Usecases
{
  public class GetBook
  {
    public readonly BookRepository _BookRepository;

    public BookDto WithId(int id)
    {
      var book = _BookRepository.GetBookWithId(id);

      return Mapper.MapToBookDto(book);
    }
  }
}