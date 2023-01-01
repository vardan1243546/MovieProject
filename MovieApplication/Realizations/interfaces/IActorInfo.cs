using MovieApplication.Models;

namespace MovieApplication.Realizations.interfaces
{
    public interface IActorInfo
    {
        IEnumerable<Actor> Actors { get; }
    }
}
