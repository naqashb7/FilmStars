using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmStars
{
    public class Films
    {

        String title { get; set; }
        String genre { get; set; }
        String series { get; set; }
        String director { get; set; }
        String mainCast { get; set; }
        String language { get; set; }
        String description { get; set; }
        int lengthOfFilm { get; set; }
        int ageRating { get; set; }
        String linkToFilm { get; set; }







        private static void FilmSelection()
        {
            Console.WriteLine("Please select one of the following to find the film you are looking for:");
            Console.WriteLine("(1) Title");
            Console.WriteLine("(2) Genre");
            Console.WriteLine("(3) Director");
            Console.WriteLine("(4) Actor/Actress");
            Console.WriteLine("(5) Language");

            int FilmSearch = Convert.ToInt32(Console.ReadLine());
        }
    }
}
