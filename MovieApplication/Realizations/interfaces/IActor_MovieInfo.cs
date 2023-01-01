using MovieApplication.Models;

namespace MovieApplication.Realizations.interfaces
{
    public interface IActor_MovieInfo
    {
        IEnumerable<Actor_Movie> Actor_Movies { get; }
    }
}
