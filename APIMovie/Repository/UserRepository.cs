using APIMovie.Interface;
using APIMovie.Models;
using Microsoft.EntityFrameworkCore;

namespace APIMovie.Repository
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(WebPhimContext webPhimContext) : base(webPhimContext) { }

    }
}
