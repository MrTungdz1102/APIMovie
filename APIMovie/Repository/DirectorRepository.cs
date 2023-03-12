using APIMovie.Interface;
using APIMovie.Models;

namespace APIMovie.Repository
{
    public class DirectorRepository : GenericRepository<Director>, IDirectorRepository
    {
        public DirectorRepository(WebPhimContext context) : base(context)
        {
        }
    }
}
