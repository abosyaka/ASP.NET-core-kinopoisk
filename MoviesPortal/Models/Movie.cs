using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesPortal.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Poster { get; set; }
        public int DirectorId { get; set; }

        [ForeignKey("DirectorId")]
        public virtual Director Director { get; set; }
        public MovieDetail MovieDetail { get; set; }
        public ICollection<Genre> Genres { get; set; }
    }
}
