using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmStars
{
    public class User
    {
        public int Age { get; set; }
        public String Name { get; set; }



        public User(int Age,String Name)
        {
            this.Name = Name;
            this.Age = Age;
        }


        public void searchGenre()
        {
            switch (Age)
            {
                case 1: if(Age > 18)
                    {
                        Console.WriteLine("");
                        // what code can I write here to give access to all movies
                    }
                        break;
                case 2: if(Age < 18 && Age > 15)
                    {
                        // what code can I write here to only give access to certain movies
                    }
                        break;
                case 3: if(Age<15 && Age > 12)
                    {
                        // what code can I write here to only give access to certain movies
                    }
                    break;
                case 4: if(Age<12 && Age > 8)
                    {
                        // what code can I write here to only give access to certain movies
                    }
                    break;
                case 5:
                    if (Age < 8)
                    {
                        // what code can I write here to only give access to certain movies
                    }
                    break;
                default: Console.WriteLine("Please enter your age");
                    break;
            }
        }

        public void searchTitle()
        {
            string titleSearch = Console.ReadLine();
            if (titleSearch != null) { 
            switch (Age)
            {
                case 1:
                    if (Age > 18)
                    {
                        Console.WriteLine("");
                        // what code can I write here to give access to all movies
                    }
                    break;
                case 2:
                    if (Age < 18 && Age > 15)
                    {
                        // what code can I write here to only give access to certain movies
                    }
                    break;
                case 3:
                    if (Age < 15 && Age > 12)
                    {
                        // what code can I write here to only give access to certain movies
                    }
                    break;
                case 4:
                    if (Age < 12 && Age > 8)
                    {
                        // what code can I write here to only give access to certain movies
                    }
                    break;
                case 5:
                    if (Age < 8)
                    {
                        // what code can I write here to only give access to certain movies
                    }
                    break;
                default:
                    Console.WriteLine("Please enter your age");
                    break;
            }
            }

        }

        public void searchDirector()
        {
            //implement method
        }

        public void acceptUserAsGuest()
        {
            //implement method
        }
    }
}
