namespace Blockbuster_Lab
{
    class Program
    {
        static void Main()
        {
            List<Movie> movies = new List<Movie>
        {
                //10 movies and categories
            new Movie("The Lion King", "Animated"),
            new Movie("The Shawshank Redemption", "Drama"),
            new Movie("The Shining", "Horror"),
            new Movie("Blade Runner", "Sci-Fi"),
            new Movie("Toy Story", "Animated"),
            new Movie("Inception", "Sci-Fi"),
            new Movie("The Godfather", "Drama"),
            new Movie("Alien", "Sci-Fi"),
            new Movie("Finding Nemo", "Animated"),
            new Movie("Psycho", "Horror")
        };
            //welcome message
            Console.WriteLine("Welcome to the very niche BlockBuster!");
            Console.WriteLine($"There are {movies.Count} movies in the list");

            while (true)
            //Start loop
            {
                Console.Write("Enter a category for some suggestions! (Animated, Drama, Horror, Sci-Fi): ");
                string userCategory = Console.ReadLine().ToLower();

                bool categoryFound = false;

                foreach (var movie in movies)
                {
                    if (movie.Category.ToLower() == userCategory)
                    {
                        Console.WriteLine("");
                        Console.Write("You should try:");
                        Console.WriteLine($" {movie.Title}");
                        Console.WriteLine("Or");
                        categoryFound = true;
                    }
                }

                if (!categoryFound)
                {
                    Console.WriteLine("No movies found in that category.");
                }

                Console.Write("Do you want to search again? (y/n) ");
                string continueInput = Console.ReadLine().ToLower();
                if (continueInput != "y")
                {
                    //end
                    break;
                }

            }
        }
    }
}


