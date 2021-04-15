using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesPortal.Models
{
    public class MovieDetail
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
        public int BoxOffice { get; set; }
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
    }
}
