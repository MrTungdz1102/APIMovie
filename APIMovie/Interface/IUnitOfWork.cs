namespace APIMovie.Interface
{
    public interface IUnitOfWork : IDisposable
    {
        IReviewRepository reviewRepository { get; }
        IUserRepository userRepository { get; }
        IDirectorRepository directorRepository { get; }

        IGenresRepository genresRepository { get; }
        IMovieRepository movieRepository { get; }
        IActorRepository actorRepository { get; }
        IDetailActorRepository detailActorRepository { get; }
        IDetailGenresRepository detailGenresRepository { get; }
        IDetailReviewRepository detailReviewRepository { get; }

        int Save();
    }
}
