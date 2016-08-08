using System.ComponentModel.DataAnnotations;

namespace mabhuku.Domain
{
    public class Rating{
        [Key]
        public int RatingId {get;set;}

        public int Score {get;set;}

        public string Comment {get;set;}

        public int BookId{get;set;}
        public Book Book {get;set;}

        public int VideoId {get;set;}

        public Video Video {get;set;}
        
    }
}