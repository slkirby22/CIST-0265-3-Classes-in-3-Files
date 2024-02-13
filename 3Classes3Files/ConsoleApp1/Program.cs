using ClassLibrary1;

string input = "";
List<Song> songs = new List<Song>();
List<Movie> movies = new List<Movie>();
List<Book> books = new List<Book>();

while (input != "5")
{
    Console.WriteLine("Hello! Would you like to...");
    Console.WriteLine("1. Add a song/movie/book.");
    Console.WriteLine("2. List all songs.");
    Console.WriteLine("3. List all movies.");
    Console.WriteLine("4. List all books.");
    Console.WriteLine("5. Exit.");

    input = Console.ReadLine();
    switch (input)
    {
        case "1":
            Console.WriteLine("Would you to add a...");
            Console.WriteLine("1. Song");
            Console.WriteLine("2. Movie");
            Console.WriteLine("3. Book");
            string addition = Console.ReadLine();
            switch (addition)
            {
                case "1":
                    Console.WriteLine("What is the name of the song?");
                    string songName = Console.ReadLine();
                    Console.WriteLine("What is the song's genre?");
                    string songGenre = Console.ReadLine();
                    Song newSong = new Song(songName, songGenre);
                    songs.Add(newSong);
                    break;
                case "2":
                    Console.WriteLine("What is the title of the movie?");
                    string movieTitle = Console.ReadLine();
                    Console.WriteLine("What is the movie's rating?");
                    string movieRating = Console.ReadLine();
                    Movie newMovie = new Movie(movieTitle, movieRating);
                    movies.Add(newMovie);
                    break;
                case "3":
                    Console.WriteLine("What is the title of the book?");
                    string bookTitle = Console.ReadLine();
                    Console.WriteLine("What is the books's genre?");
                    string bookGenre = Console.ReadLine();
                    Book newBook = new Book(bookTitle, bookGenre);
                    books.Add(newBook);
                    break;
                default:
                    break;
            }
            break;
        case "2":
            Console.WriteLine("List all songs:");
            foreach (var song in songs)
            {
                song.ShowInfo();
            }
            break;
        case "3":
            Console.WriteLine("List all movies:");
            foreach (var movie in movies)
            {
                movie.ShowInfo();
            }
            break;
        case "4":
            Console.WriteLine("List all books:");
            foreach (var book in books)
            {
                book.ShowInfo();
            }
            break;
        default:
            break;
    }
}