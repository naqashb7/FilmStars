namespace FilmStars;




public class program
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Welcome to FilmStars!");
        Console.WriteLine("Are you looking for a Film or a TV show?");
        String initialSearch = Console.ReadLine();

        switch (initialSearch)
        {
            case "film":
                if( initialSearch.ToLower() == "film")
                {
                    Console.WriteLine("Do you know the title of the film you would like to search for?");
                    String q1 = Console.ReadLine();
                    if (q1.ToLower() == "no")
                    {
                        Console.WriteLine("Do you know the Genre of the film you would like to search for?");
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
                if(initialSearch.ToLower()== "tv show"){

                }
                break;
        }
        
        
        

    }
}