using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ExercisseClass8

{
    public class Cinema
    {
        public string Name { get; set; }
        public List<int> Halls { get; set; }
        public List<Movie> ListOfMovies { get; set; }

        public void MoviePlaying(Movie movie)
        {
            Console.WriteLine($"Watching {movie.Title}");
        }

        public Cinema()
        {
            Halls = new List<int>();
            ListOfMovies = new List<Movie>();
        }
        public Cinema(string name)
        {
            this.Name = name;
            Halls = new List<int>();
            ListOfMovies = new List<Movie>();
        }
    }
}
