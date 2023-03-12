using APIMovie.Interface;
using APIMovie.Models;

namespace APIMovie.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly WebPhimContext _context;
        public UnitOfWork(WebPhimContext context)
        {
            _context = context;
            reviewRepository = new ReviewRepository(context);
            userRepository = new UserRepository(context);
            actorRepository= new ActorRepository(context);
            genresRepository= new GenresRepository(context);
            movieRepository= new MovieRepository(context);
            directorRepository= new DirectorRepository(context);
            detailActorRepository= new DetailActorRepository(context);
            detailGenresRepository= new DetailGenresRepository(context);
            detailReviewRepository= new DetailReviewRepository(context);
        }

        public IReviewRepository reviewRepository { get; }

        public IUserRepository userRepository { get; }

        public IDirectorRepository directorRepository { get; }

        public IGenresRepository genresRepository { get; }

        public IMovieRepository movieRepository { get; }

        public IActorRepository actorRepository { get; }

        public IDetailActorRepository detailActorRepository { get; }

        public IDetailGenresRepository detailGenresRepository { get; }

        public IDetailReviewRepository detailReviewRepository { get; }

        public void Dispose()
        {
            _context.Dispose();
        }

        public int Save()
        {
            return _context.SaveChanges();
        }
    }
}
