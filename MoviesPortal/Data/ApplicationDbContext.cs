using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using MoviesPortal.Models;

namespace MoviesPortal.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Genre>().HasData(
                new Genre
                {
                    Id = 1,
                    Name = "Action"
                },
                new Genre
                {
                    Id = 2,
                    Name = "Comedy"
                },
                new Genre
                {
                    Id = 3,
                    Name = "Drama"
                }
                );

            builder.Entity<Director>().HasData(
                new Director 
                {
                    Id = 1,
                    Name = "Steven Spielberg"
                },
                new Director
                {
                    Id = 2,
                    Name = "Michael Bay"
                },
                new Director
                {
                    Id = 3,
                    Name = "Stanley Kubrick"
                }
                );

            builder.Entity<Movie>().HasData(
                new Movie
                {
                    Id = 1,
                    Title = "Jaw",
                    Poster = "https://theplaylist.net/wp-content/uploads/2012/04/as-jaws-heads-to-blu-ray-five-things-you-might-not-know-about-steven-spielberg-game-changer.jpg",
                    DirectorId = 1,
                },
                new Movie
                {
                    Id = 2,
                    Title = "Transformers",
                    Poster = "https://upload.wikimedia.org/wikipedia/ru/2/28/Transformers_The_Last_Knight.jpg",
                    DirectorId = 2
                },
                new Movie
                {
                    Id = 3,
                    Title = "The Shining",
                    Poster = "https://images-na.ssl-images-amazon.com/images/S/pv-target-images/d3271cc1ecd6ad5fef1e5b06fd3ef83f4bfc384570fbda85c094857762dc4d47._RI_V_TTW_.jpg",
                    DirectorId = 3
                }
                );

            builder.Entity<MovieDetail>().HasData(
                new MovieDetail
                {
                    Id = 1,
                    MovieId = 1,
                    BoxOffice = 120000000,
                    Description = "When a killer shark unleashes chaos on a beach community, it's up to a local sheriff, a marine biologist, and an old seafarer to hunt the beast down."
                },
                new MovieDetail
                {
                    Id = 2,
                    MovieId = 2,
                    BoxOffice = 400000000,
                    Description = "An ancient struggle between two Cybertronian races, the heroic Autobots and the evil Decepticons, comes to Earth, with a clue to the ultimate power held by a teenager."
                },
                new MovieDetail
                {
                    Id = 3,
                    MovieId = 3,
                    BoxOffice = 200000000,
                    Description = "A family heads to an isolated hotel for the winter where a sinister presence influences the father into violence, while his psychic son sees horrific forebodings from both past and future."
                }
                );
        }
        public DbSet<MoviesPortal.Models.Director> Director { get; set; }
        public DbSet<MoviesPortal.Models.MovieDetail> MovieDetail { get; set; }
        public DbSet<MoviesPortal.Models.Genre> Genre { get; set; }
        public DbSet<MoviesPortal.Models.Movie> Movie { get; set; }
    }
}
