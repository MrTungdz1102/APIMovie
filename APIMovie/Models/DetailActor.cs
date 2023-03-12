namespace APIMovie.Models
{
    public class DetailActor
    {
        public string MovieID { get; set; } = null!;
        public string ActorID { get; set; } = null!;

        public Movie? movie { get; set; }
        public Actor? actor { get; set; }
    }
}
