using MovieApplication.Models;

namespace MovieApplication.Realizations.interfaces
{
    public interface ICinemaInfo
    {
        IEnumerable<Cinema> Cinemas { get; }
    }
}
