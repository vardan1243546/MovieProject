using MovieApplication.Models;
using MovieApplication.Realizations.interfaces;

namespace MovieApplication.Realizations.classes
{
    public class Movie_ActorRealization:IActor_MovieInfo
    {
        public IEnumerable<Actor_Movie> Actor_Movies
        {
            get
            {
                return new List<Actor_Movie>
                {

                        new Actor_Movie()
                        {
                            ActorId=5,
                            MovieId=6,
                        },
                        new Actor_Movie()
                        {
                            ActorId=4,
                            MovieId=6,
                        },
                        new Actor_Movie()
                        {
                            ActorId=3,
                            MovieId=6,
                        },
                        new Actor_Movie()
                        {
                            ActorId=1,
                            MovieId=3,
                        },
                        new Actor_Movie()
                        {
                            ActorId=5,
                            MovieId=3,
                        }, new Actor_Movie()
                        {
                            ActorId=4,
                            MovieId=2,
                        }, new Actor_Movie()
                        {
                            ActorId=5,
                            MovieId=5,
                        },
                        new Actor_Movie()
                        {
                            ActorId=3,
                            MovieId=6,
                        },
                        new Actor_Movie
                        {
                          ActorId=4,
                            MovieId=6,
                        }, new Actor_Movie
                        {
                          ActorId=5,
                            MovieId=6,
                        }
                };
            }
        }
    }
}
