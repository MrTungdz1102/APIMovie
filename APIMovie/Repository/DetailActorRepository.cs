using APIMovie.Interface;
using APIMovie.Models;

namespace APIMovie.Repository
{
    public class DetailActorRepository : GenericRepository<DetailActor>, IDetailActorRepository
    {
        public DetailActorRepository(WebPhimContext context) : base(context)
        {
        }
    }
}
