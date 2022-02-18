using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmStars
{
    public class TVShows
    {
        String title { get; set; }
        String genre { get; set; }
        String series { get; set; }
        String director { get; set; }
        String mainCast { get; set; }
        String language { get; set; }
        String description { get; set; }
        int lengthOfEpisode { get; set; }
        int ageRating { get; set; }
        String linkToEpisode { get; set; }




        private static void ShowSelection()
        {
            Console.WriteLine("Please select one of the following to find the show you are looking for:");
            Console.WriteLine("(1) Title");
            Console.WriteLine("(2) Genre");
            Console.WriteLine("(3) Director");
            Console.WriteLine("(4) Actor/Actress");
            Console.WriteLine("(5) Language");
            Console.WriteLine("(6)");

            int ShowSearch = Convert.ToInt32(Console.ReadLine());
        }





    }
}
