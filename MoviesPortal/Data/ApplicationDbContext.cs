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
        public DbSet<MoviesPortal.Models.Director> Director { get; set; }
        public DbSet<MoviesPortal.Models.MovieDetail> MovieDetail { get; set; }
        public DbSet<MoviesPortal.Models.Genre> Genre { get; set; }
        public DbSet<MoviesPortal.Models.Movie> Movie { get; set; }
    }
}
