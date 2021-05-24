using Microsoft.AspNetCore.Mvc.Rendering;
using MoviesPortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesPortal.ViewModels
{
    public class AddMovieGenreViewModel
    {
        public Movie Movie { get; set; }
        public List<SelectListItem> Genres { get; set; }

        public int MovieId;
        public int GenreId;

        public AddMovieGenreViewModel() { }

        public AddMovieGenreViewModel(Movie movie, IEnumerable<Genre> genres)
        {
            Genres = new List<SelectListItem>();

            foreach(var genre in genres)
            {
                Genres.Add(new SelectListItem
                {
                    Value = genre.Id.ToString(),
                    Text = genre.Name
                });
            }

            Movie = movie;
        }
    }
}
