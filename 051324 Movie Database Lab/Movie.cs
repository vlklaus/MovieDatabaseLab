using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _051324_Movie_Database_Lab
{
    public class Movie
    {
        // properties
        public string Title { get; set; }
        public string Category { get; set; }
        public static object TryParse { get; private set; }


        // constructor
        public Movie(string _title, string _category)
        {
            Title = _title;
            Category = _category;
        }


        // continue program method loop
        public static bool GetContinue()
        {
            bool result = true;
            while (true)
            {
                Console.Write("See a new category? (y/n) ");
                string choice = Console.ReadLine().ToLower().Trim();

                if (choice == "y")
                {
                    result = true;
                    break;
                } else if (choice == "n")
                {
                    result = false;
                    break;
                } else
                {
                    Console.WriteLine("Invalid input. Try again.");
                }
            }
            return result;
        }
    }
}
