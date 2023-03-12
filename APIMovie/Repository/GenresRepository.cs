using APIMovie.Interface;
using APIMovie.Models;

namespace APIMovie.Repository
{
    public class GenresRepository : GenericRepository<Genres>, IGenresRepository
    {
        public GenresRepository(WebPhimContext context) : base(context)
        {
        }
    }
}
