using APIMovie.Interface;
using APIMovie.Models;

namespace APIMovie.Repository
{
    public class DetailReviewRepository : GenericRepository<DetailReview>, IDetailReviewRepository
    {
        public DetailReviewRepository(WebPhimContext context) : base(context)
        {
        }
    }
}
