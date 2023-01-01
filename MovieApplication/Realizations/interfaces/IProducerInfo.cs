using MovieApplication.Models;

namespace MovieApplication.Realizations.interfaces
{
    public interface IProducerInfo
    {
        IEnumerable<Producer> Producers { get; }
    }
}
