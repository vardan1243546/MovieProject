using MovieApplication.Models;
using MovieApplication.Realizations.interfaces;

namespace MovieApplication.Services.Repository
{
    public interface IActorRepository:IActorInfo
    {
        IEnumerable<Actor> GetAll();

        Actor GetById(int id,Actor model);

        void Delete(int id);

        Actor Update(int id,Actor model);

        void Add(Actor actor);
    }
}
