// DECLARACIÓN DE USING
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Plugins;
using RazorPageMovie.Data;
//using System.ComponentModel.DataAnnotations;

namespace RazorPageMovie.Models
{
    public static class SeedData
    {
        // INCIALIZAR PARA INTRODUCIR DATOS A LA DB CUANDO DE EJECUTE EL PROYECTO
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPageMovieContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<RazorPageMovieContext>>()))
            {
                if (context == null || context.Movie == null)
                {
                    throw new ArgumentException("Null RazorPagesMovieContext");
                }
                // PARA MIRAR CUALQUIER PELICULA
                if (context.Movie.Any()) 
                {
                    return; // LA DB MUESTRA TODO EL CONTENIDO DE LA CLASE
                }
                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "When Harry met Sally",
                        ReleaseDate = DateTime.Parse("1982-2-12"),
                        Genre = "Romantic Comedy",
                        Price = 7.99M,
                        Rating = "R"
                    },
                    new Movie
                    {
                        Title = "GhostBusters",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Genre = "Comedy",
                        Price = 8.99M,
                        Rating = "R"
                    },
                    new Movie
                    {
                        Title = "GhostBusters 2",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Genre = "Comedy",
                        Price = 9.99M,
                        Rating = "R"
                    },
                    new Movie
                    {
                        Title = "Rio Bravo",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Genre = "Western",
                        Price = 3.99M,
                        Rating = "R"
                    }
                    );
                context.SaveChanges();
            }
        }
        
    }
}
