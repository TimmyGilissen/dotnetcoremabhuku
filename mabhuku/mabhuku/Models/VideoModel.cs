using System.Collections.Generic;

namespace mabhuku.Models
{
  public class VideoModel
  {
    public int Id { get; set; }
    public string Title { get; set; }
    public string Link { get; set; }
    public List<RatingModel> Ratings { get; set; }
  }
}