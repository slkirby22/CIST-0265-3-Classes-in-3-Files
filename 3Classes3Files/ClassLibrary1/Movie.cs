using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Movie
    {
        public string Title { get; set; }
        public string Rating { get; set; }

        //constructor
        public Movie(string title, string rating)
        {
            Title = title;
            Rating = rating;
        }
        public void ShowInfo()
        {
            Console.WriteLine("Movie Title: " + Title + ". Rating: " + Rating);
        }
    }
}