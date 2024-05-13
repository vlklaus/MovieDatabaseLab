using _051324_Movie_Database_Lab;

List<Movie> movies = new List<Movie>()
{
    new Movie("Interstellar", "scifi"), //movies.Add(new Movie ("Interstellar", "Sci-Fi")); // Sci-Fi, Adventure
    new Movie("Eternal Sunshine of the Spotless Mind", "romance"),
    new Movie("Barbarian", "horror"),
    new Movie("Talk to Me", "horror"),
    new Movie("How to Lose a Guy in 10 Days", "romance"),
    new Movie("Back to the Future", "scifi"),
    new Movie("Jujutsu Kaisen 0", "action"),
    new Movie("Colorful", "fantasy"),
    new Movie("Fight Club", "thriller"),
    new Movie("Goodwill Hunting", "drama"),
    new Movie("Killers of the Flower Moon", "crime"),
    new Movie("Goodfellas", "crime")
};

Console.WriteLine("Welcome to the Movie List Application!");
Console.WriteLine($"There are {movies.Count} movies in this list.");

bool runAgain = true;
while (runAgain)
{       
    Console.Write("What category are you interest in? ");
    string category = Console.ReadLine().ToLower().Trim();

    // category not available 
    if (category != "scifi" && category != "romance" && category != "horror" && category != "action" && category != "action" && category != "thriller" && category != "drama" && category != "crime")
    {
        Console.WriteLine("We don't have any movies with that category. Try again please!");
        continue;
    }
           
    foreach (Movie movie in movies) // finding the correct category
    {
        if (movie.Category == category)
        {
            List<Movie> moviefiltered = movies.Where(m => m.Category == category).ToList();
            foreach (Movie m in moviefiltered)
            {

                Console.WriteLine(m.Title);
            }
            break;
        }
    }

    Console.WriteLine();
    runAgain = Movie.GetContinue(); // loop program again
}