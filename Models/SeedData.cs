using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Movies.Data;
using System;
using System.Linq;
namespace Movies.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MoviesContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MoviesContext>>()))
            {
                // Look for any movies already in DB
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }
                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "Toy Story 4",
                        ReleaseDate = DateTime.Parse("2019-6-21"),
                        Genre = "Animation",
                        Director = "Josh Cooley"
                    },
                    new Movie
                    {
                        Title = "A Star Is Born",
                        ReleaseDate = DateTime.Parse("2018-10-5"),
                        Genre = "Drama",
                        Director = "Bradley Cooper"
                    },
                    new Movie
                    {
                        Title = "Mission: Impossible - Fallout",
                        ReleaseDate = DateTime.Parse("2018-7-27"),
                        Genre = "Action",
                        Director = "Christopher McQuarrie"
                    },
                    new Movie
                    {
                        Title = "The Dark Knight Rises",
                        ReleaseDate = DateTime.Parse("2012-7-20"),
                        Genre = "Action",
                        Director = "Christopher Nolan"
                    },
                    new Movie
                    {
                        Title = "Batman",
                        ReleaseDate = DateTime.Parse("2020-10-5"),
                        Genre = "Action",
                        Director = "Alex Adiyasuren"
                    },
                    new Movie
                    {
                        Title = "Man of steel",
                        ReleaseDate = DateTime.Parse("2021-10-5"),
                        Genre = "Action",
                        Director = "Nicole Adiyasuren"
                    },
                    new Movie
                    {
                        Title = "Wonder woman",
                        ReleaseDate = DateTime.Parse("2022-10-5"),
                        Genre = "Action",
                        Director = "Brad Adiyasuren"
                    }, 
                    new Movie
                    {
                        Title = "Up",
                        ReleaseDate = DateTime.Parse("2016-10-5"),
                        Genre = "Action",
                        Director = "Enkh Adiyasuren"
                    }, 
                    new Movie
                    {
                        Title = "Spider-man",
                        ReleaseDate = DateTime.Parse("2022-10-5"),
                        Genre = "Action",
                        Director = "Khal Adiyasuren"
                    }, 
                    new Movie
                    {
                        Title = "Eternals",
                        ReleaseDate = DateTime.Parse("2021-10-5"),
                        Genre = "Action",
                        Director = "Ganbat Adiyasuren"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
