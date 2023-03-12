namespace APIMovie.Models
{
    public class DetailReview
    {
        public string MovieID { get; set; } = null!;
        public string ReviewID { get; set; } = null!;
        public Movie? movie { get; set; }
        public ReView? reView { get; set; }
    }
}
