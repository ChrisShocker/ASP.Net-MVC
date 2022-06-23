namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Genre Genre { get; set; }
        public DateTime releaseDate { get; set; }
        public DateTime dateAdded { get; set; }
        public int Stock { get; set; }

        public Movie()
        {
            Title = "";
        }

        public Movie(string title)
        {
            Title = title;
        }

    }
}
