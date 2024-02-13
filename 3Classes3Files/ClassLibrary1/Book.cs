namespace ClassLibrary1
{
    public class Book
    {
        public string Title { get; set; }
        public string Genre { get; set; }

        //constructor
        public Book(string title, string genre)
        {
            Title = title;
            Genre = genre;
        }
        public void ShowInfo()
        {
            Console.WriteLine("Book Title: " + Title + ". Genre: " + Genre);
        }
    }
}