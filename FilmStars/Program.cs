namespace FilmStars;




public class program
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Welcome to FilmStars!");
        Console.WriteLine("Are you looking for a Film or a TV show?");
        Console.WriteLine("Please enter (1) for a Film or (2) for a TV show");
        int initialSearch = Convert.ToInt32(Console.ReadLine());

       




        switch (initialSearch) {
            case 1: Films.FilmSelection();
                break;
            case 2:
                break;
            default:
                break;
        }
    }





    private static void FilmSelection()
    {
        Console.WriteLine("Please select one of the following to find the film you are looking for:");
        Console.WriteLine("(1) Title");
        Console.WriteLine("(2) Genre");
        Console.WriteLine("(3) Director");
        Console.WriteLine("(4) Actor/Actress");
        Console.WriteLine("(5) Language");

        int FilmSearch= Convert.ToInt32(Console.ReadLine());
    }
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