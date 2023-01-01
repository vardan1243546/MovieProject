using MovieApplication.Data;
using MovieApplication.Models;
using MovieApplication.Services.Repository;

namespace MovieApplication.Services.ClassesRepository
{
    public class ActorRepository : IActorRepository
    {

        private readonly AppDbContext context;

        public IEnumerable<Actor> Actors => throw new NotImplementedException();

        public ActorRepository(AppDbContext context)
        {
                this.context=context;
        }
        public IEnumerable<Actor> GetAll()
        {
               var content= context.Actors.ToList();
              return content;
        }
        public void Add(Actor actor)
        {
           context.Actors.Add(actor);
        }
        public void Delete(int id)
        {
        }

        public Actor GetById(int id, Actor model)
        {
            throw new NotImplementedException();
        }

        public Actor Update(int id, Actor model)
        {
            throw new NotImplementedException();
        }
    }
}
