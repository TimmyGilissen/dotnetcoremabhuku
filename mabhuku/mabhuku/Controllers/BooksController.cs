using System.Linq;
using mabhuku.Commands;
using mabhuku.Mappers;
using mabhuku.Models;
using mabhuku.Usecases;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace mabhuku.Controllers
{
    public class BooksController : Controller
    {
        private readonly ILogger<BooksController> _logger;

        public BooksController(ILogger<BooksController> logger){
            _logger = logger;
        }

        public IActionResult Index()
        {
            var getAllBooks = new GetAllBooks();
            return View(getAllBooks.Execute().Select(Mapper.MapToBookModel).ToList());
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View(new BookModel());
        }

        [HttpPost]
        public IActionResult Add(BookModel book){
            _logger.LogDebug(book.Title);

            var addBook = new AddBook();

          addBook.Execute(new AddBookCommand
          {
            Author = book.Author,
            Link = book.Link,
            Title = book.Title,
            Description = book.Description
          });

          return Content("Book has been added");
        }

      [HttpGet]
      public IActionResult Edit(int id)
      {
        _logger.LogDebug("entered edit mode with id: " + id);
        var getBook = new GetBook();

        var book = getBook.WithId(id);

        return View(Mapper.MapToBookModel(book));

      }

        public IActionResult Error()
        {
            return View();
        }
    }
}
