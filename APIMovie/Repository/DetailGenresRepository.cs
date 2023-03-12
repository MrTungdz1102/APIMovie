using APIMovie.Interface;
using APIMovie.Models;

namespace APIMovie.Repository
{
    public class DetailGenresRepository : GenericRepository<DetailGenres>, IDetailGenresRepository
    {
        public DetailGenresRepository(WebPhimContext context) : base(context)
        {
        }
    }
}
