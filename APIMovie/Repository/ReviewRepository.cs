using APIMovie.Interface;
using APIMovie.Models;
using Microsoft.EntityFrameworkCore;

namespace APIMovie.Repository
{
    public class ReviewRepository : GenericRepository<ReView>, IReviewRepository
    {
        public ReviewRepository(WebPhimContext webPhimContext) : base(webPhimContext)
        {

        }
    }
}
