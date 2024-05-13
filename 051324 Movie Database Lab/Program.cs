using _051324_Movie_Database_Lab;

List<Movie> movies = new List<Movie>()
{
    new Movie("Interstellar", "scifi", "2h 49m", "2014"), //movies.Add(new Movie ("Interstellar", "Sci-Fi")); // Sci-Fi, Adventure
    new Movie("Eternal Sunshine of the Spotless Mind", "romance", "1h 48m", "2004"),
    new Movie("Talk to Me", "horror", "1h 34m", "2023"),
    new Movie("Barbarian", "horror", "1h 42m", "2022"),
    new Movie("How to Lose a Guy in 10 Days", "romance", "1h 50m", "2003"),
    new Movie("Back to the Future", "scifi", "1h 50m", "2003"),
    new Movie("Jujutsu Kaisen 0", "action", "1h 45m", "2022"),
    new Movie("Colorful", "fantasy", "2h 7m", "2010"),
    new Movie("Fight Club", "thriller", "2h 19m", "1999"),
    new Movie("Good Will Hunting", "drama", "2h 6m", "1997"),
    new Movie("Killers of the Flower Moon", "crime", "3h 26m", " 2023"),
    new Movie("Goodfellas", "crime", "2h 26m", "1990")
};

Console.WriteLine("Welcome to the Movie List Application!");
Console.WriteLine($"There are {movies.Count} movies in this list.");

for (int i = 0; i < movies.Count; i++)
{
    Console.WriteLine(movies[i].Category);
}


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
            List<Movie> movieFiltered = movies.Where(m => m.Category == category).OrderBy(x=> x.Title).ToList();
            foreach (Movie m in movieFiltered)
            {

                Console.WriteLine();
                Console.WriteLine(m.Title);
                Console.WriteLine($"Year Released: {m.YearRelease}");
                Console.WriteLine($"Runtime: { m.RunTime}");
            }
            break;
        }
    }

    Console.WriteLine();
    runAgain = Movie.GetContinue(); // loop program again
}