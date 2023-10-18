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
                Console.WriteLine("");
                Console.Write("You should try: ");

                foreach (var movie in movies)
                {
                    if (movie.Category.ToLower() == userCategory)
                    {
                        
                        Console.WriteLine($"'{movie.Title}'");
                        Console.Write("Or ");
                        categoryFound = true;
                    }
                }

                if (!categoryFound)
                {
                    Console.WriteLine("No movies found in that category.");
                }

                while (true)
                {
                    Console.Write("Would you like another suggestion? (y/n)? ");
                    string continueInput = Console.ReadLine().ToLower();
                    if (continueInput == "n")
                    {
                        return; // Exit 
                    }
                    else if (continueInput == "y")
                    {
                        break; // Continue and loop back to prompt
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter 'y' to continue or 'n' to stop.");
                    }
                }
            }
        }
    }
}


