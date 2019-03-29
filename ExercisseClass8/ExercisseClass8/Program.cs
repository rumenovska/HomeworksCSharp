﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisseClass8
{
    class Program
    {
        static void Main(string[] args)
        {
            #region CinemaMovies
            Movie movie1 = new Movie("A star is born", Genre.Drama, 5);
            Movie movie2 = new Movie("American Pie", Genre.Comedy, 4);
            Movie movie3 = new Movie("Saw", Genre.Horror, 4);
            Movie movie4 = new Movie("The Shining", Genre.Horror, 4);
            Movie movie5 = new Movie("Rambo", Genre.Action, 4);
            Movie movie6 = new Movie("The Terminator", Genre.Action, 4);
            Movie movie7 = new Movie("Forrest Gump", Genre.Drama, 4);
            Movie movie8 = new Movie("12 Angru Men", Genre.Drama, 4);
            Movie movie9 = new Movie("Passengers", Genre.SciFi, 4);
            Movie movie10 = new Movie("Interstellar", Genre.SciFi, 4);

            List<Movie> moviesList1 = new List<Movie> {movie1, movie2, movie3 ,movie4, movie5, movie6, movie7, movie8, movie9, movie10 };
            Movie movie11 = new Movie("Airplane", Genre.Comedy, 4);
            Movie movie12 = new Movie("Johnny English", Genre.Comedy, 3);
            Movie movie13 = new Movie("The Ring", Genre.Horror, 4);
            Movie movie14 = new Movie("Sinister", Genre.Horror, 4);
            Movie movie15 = new Movie("RoboCop", Genre.Action, 5);
            Movie movie16 = new Movie("Judge Dredd", Genre.Action, 4);
            Movie movie17 = new Movie("The Social Network", Genre.Drama, 4);
            Movie movie18 = new Movie("The Shawshank Redemption", Genre.Drama, 3);
            Movie movie19 = new Movie("Inception", Genre.SciFi, 4);
            Movie movie20 = new Movie("Avatar", Genre.SciFi, 4);

            List<Movie> moviesList2 = new List<Movie> {movie11, movie12, movie13, movie14, movie15,movie16, movie17, movie18, movie19,movie20 };

            Cinema cinema1 = new Cinema("Cineplex");
            cinema1.Halls = new List<int> {1,2,3,4,5,6 };
            cinema1.ListOfMovies = moviesList1;

            Cinema cinema2 = new Cinema("Milenium");
            cinema2.Halls = new List<int>() { 1, 2 };
            cinema2.ListOfMovies = moviesList2;
            
            

            #endregion
            try
            {
                Console.WriteLine("Choose cinema:");
                Console.WriteLine($"Enter 1 for {cinema1.Name}");
                Console.WriteLine($"Enter 2 for {cinema2.Name}");
                int cinemaInput = Int32.Parse(Console.ReadLine());
                Cinema currentCinema = new Cinema();
                if(cinemaInput == 1)
                {
                    currentCinema = cinema1;
                }
                else if(cinemaInput == 2)
                {
                    currentCinema = cinema2;
                }
                else
                {
                    throw new Exception("Wrong input! You have to enter 1 or 2");
                }

                Console.WriteLine("Movies in this cinema:");
                Console.WriteLine("1) Show all movies");
                Console.WriteLine("2) Show by genre");
                int moviesInput = Int32.Parse(Console.ReadLine());
                if(moviesInput == 1)
                {
                    Console.WriteLine("Choose a movie to watch: (Enter movie name)");

                    foreach(var m in currentCinema.ListOfMovies)
                    {
                        Console.WriteLine($"Movie: {m.Title} Price: {m.TicketPrice}");
                    }

                    string inputMovieName = Console.ReadLine();
                    Movie currentMovie = currentCinema
                        .ListOfMovies
                        .Where(m => m.Title.Trim().ToLower() == inputMovieName.Trim().ToLower())
                        .FirstOrDefault();

                    currentCinema.MoviePlaying(currentMovie);

                }
                else if (moviesInput == 2)
                {
                    Console.WriteLine("Enter genre number:");
                    Console.WriteLine("1) Comedy");
                    Console.WriteLine("2) Horror");
                    Console.WriteLine("3) Action");
                    Console.WriteLine("4) Drama");
                    Console.WriteLine("5) SciFi");
                    int inputGenre = Int32.Parse(Console.ReadLine());
                    Genre currentGenre = new Genre();
                    switch (inputGenre)
                    {
                        case 1:
                            currentGenre = Genre.Comedy;
                            break;
                        case 2:
                            currentGenre = Genre.Horror;
                            break;
                        case 3:
                            currentGenre = Genre.Action;
                            break;
                        case 4:
                            currentGenre = Genre.Drama;
                            break;
                        case 5:
                            currentGenre = Genre.SciFi;
                            break;
                        default:
                            throw new Exception("The genre input was not correct! Sorry, you broke it!");
                    }

                    Console.WriteLine("Choose a movie to watch: ( Write the name )");
                    List<Movie> personMovies = new List<Movie>();

                    List<Movie> genreMovies = currentCinema
                        .ListOfMovies
                        .Where(movie => movie.Genre == currentGenre)
                        .ToList();

                    foreach (var movie in genreMovies)
                    {
                        personMovies.Add(movie);
                        Console.WriteLine(movie.Title);
                    }
                    string inputMovie = Console.ReadLine();
                    Movie currentChosenMovie = personMovies
                        .Where(movie => movie.Title.Trim().ToLower() == inputMovie.Trim().ToLower())
                        .FirstOrDefault();

                    currentCinema.MoviePlaying(currentChosenMovie);


                }
                else
                {
                    throw new Exception("You have entered a wrong input!");
                }

            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

           
            Console.ReadLine();
        }
    }
}
