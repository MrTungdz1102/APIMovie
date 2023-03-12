namespace APIMovie.Models
{
    public class DetailGenres
    {
        public string MovieID { get; set; } = null!;
        public string GenresID { get; set; } = null!;

        public Movie? movie { get; set; }
        public Genres? genres { get; set; }
    }
}
