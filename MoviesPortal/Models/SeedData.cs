using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MoviesPortal.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesPortal.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
            {
                if (context.Genre.Any())
                {
                    return;
                }

                context.Genre.AddRange(
                    new Genre
                    {
                        Name = "Action"
                    },
                    new Genre
                    {
                        Name = "Comedy"
                    },
                    new Genre
                    {
                        Name = "Drama"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
