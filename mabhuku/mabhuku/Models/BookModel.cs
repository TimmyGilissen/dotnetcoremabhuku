using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;

namespace mabhuku.Models
{
  public class BookModel
  {
      public int Id { get; set; }

      public string Title { get; set; }

      public string Author { get; set; }

      public string Link { get; set; }

      public string Description { get; set; }

      public List<RatingModel> Ratings { get; set; }
  }
}