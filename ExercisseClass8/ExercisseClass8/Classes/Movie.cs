using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisseClass8
{
    public class Movie
    {
        public string Title { get; set; }
        public Genre Genre { get; set; }
        public int Rating { get; set; }
        public int TicketPrice { get; set; }

        public Movie(string title, Genre genre, int rating)
        {
            this.Title = title;
            this.Genre = Genre;
            try
            {
                if (rating >= 1 && rating <= 5)
                {
                    this.Rating = rating;

                }
                else
                {
                    throw new Exception("Rating should be a number from 1 to 5");
                }

            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                this.Rating = 1;
                Console.WriteLine(ex.Message);
            }

            this.TicketPrice = 5 * rating;
        }
    }
}
