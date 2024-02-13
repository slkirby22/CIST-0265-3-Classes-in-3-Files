using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Song
    {
        public string Name { get; set; }
        public string Genre { get; set; }

        //constructor
        public Song(string name, string genre)
        {
            Name = name;
            Genre = genre;
        }
        public void ShowInfo()
        {
            Console.WriteLine("Song Name: " + Name + ". Genre: " + Genre);
        }
    }
}