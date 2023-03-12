using APIMovie.Interface;
using APIMovie.Models;

namespace APIMovie.Repository
{
    public class ActorRepository : GenericRepository<Actor>, IActorRepository
    {
        public ActorRepository(WebPhimContext context) : base(context)
        {
        }
    }
}
