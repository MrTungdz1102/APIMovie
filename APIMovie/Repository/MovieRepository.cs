using APIMovie.Interface;
using APIMovie.Models;

namespace APIMovie.Repository
{
    public class MovieRepository : GenericRepository<Movie>, IMovieRepository
    {
        public MovieRepository(WebPhimContext context) : base(context)
        {
        }
    }
}
