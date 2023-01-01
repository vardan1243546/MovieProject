using MovieApplication.Models;

namespace MovieApplication.Realizations.interfaces
{
    public interface IMovieInfo
    {
        IEnumerable<Movie> Movies { get; }
    }
}
