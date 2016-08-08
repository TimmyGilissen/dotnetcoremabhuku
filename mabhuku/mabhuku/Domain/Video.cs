using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace mabhuku.Domain
{
    public class Video{
        [Key]
        public int VideoId {get;set;}

        public string Title {get;set;}

        public string Link {get;set;}

        public List<Rating> Ratings {get;set;}
    }
}