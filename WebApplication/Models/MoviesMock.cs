using System.Collections.Generic;

namespace WebApplication.Models
{
    public class MoviesMock
    {
        private static List<Movie> MoviesList { get; set; } = new List<Movie>
        {
            new Movie {Name = "Shrek", Id = 1},
            new Movie {Name = "Wall-e", Id = 2}
        };

        public static List<Movie> GetMovies()
        {
            return MoviesList;
        }
    }
}