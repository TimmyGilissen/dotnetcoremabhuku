using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace mabhuku.Domain
{
    public class Book{
        [Key]
        public int BookId{get;set;}

        public string Title {get; set;}

        public string Author {get;set;}

        public string Link {get;set;}

        public string Description{get;set;}

        public List<Rating> Ratings{get;set;}
    }
}