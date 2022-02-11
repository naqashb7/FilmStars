namespace FilmStars;




public class program
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Welcome to FilmStars!");
        Console.WriteLine("Are you looking for a Film or a TV show?");
        String initialSearch = Console.ReadLine();
        String searchResult= initialSearch.ToLower();

        switch (searchResult)
        {
            case "film":
                if( searchResult == "film")
                {
                    Console.WriteLine("Do you know the title of the show you would like to search for?");
                    String q1 = Console.ReadLine();
                    if (q1.ToLower() == "no")
                    {
                        Console.WriteLine("Do you know the genre of the show you would like to search for?");
                        String q2 = Console.ReadLine();
                        if (q2.ToLower() == "no")
                        {
                            Console.WriteLine("Is there a specific director you are looking for?");
                            String q3 = Console.ReadLine();
                            if (q3.ToLower() == "no")
                            {
                                Console.WriteLine("Is there a specific actor/actress you are looking for?");
                                String q4 = Console.ReadLine();
                                if (q4.ToLower() == "no")
                                {
                                    Console.WriteLine("Is there a specific language you are looking for?");
                                    String q5 = Console.ReadLine();
                                }
                            }
                        }
                    }
                }
                break;
            case "tv show":
                if (searchResult == "tv show")
                {
                    Console.WriteLine("Do you know the title of the TV show you would like to search for?");
                    String q1 = Console.ReadLine();
                    if (q1.ToLower() == "no")
                    {
                        Console.WriteLine("Do you know the Genre of the TV show you would like to search for?");
                        String q2 = Console.ReadLine();
                        if (q2.ToLower() == "no")
                        {
                            Console.WriteLine("Is there a specific director you are looking for?");
                            String q3 = Console.ReadLine();
                            if (q3.ToLower() == "no")
                            {
                                Console.WriteLine("Is there a specific actor/actress you are looking for?");
                                String q4 = Console.ReadLine();
                                if (q4.ToLower() == "no")
                                {
                                    Console.WriteLine("Is there a specific language you are looking for?");
                                    String q5 = Console.ReadLine();
                                }
                            }
                        }
                    }
                }
                break;
        }
        
        
        

    }
}