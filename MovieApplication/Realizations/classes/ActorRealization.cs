using MovieApplication.Models;
using MovieApplication.Realizations.interfaces;
using static System.Net.WebRequestMethods;

namespace MovieApplication.Realizations.classes
{
    public class ActorRealization:IActorInfo
    {
        public IEnumerable<Actor> Actors
        {
            get
            {
                return new List<Actor>
                {
                         new Actor()
                        {
                            FullName="Actor 1",
                            Bio="This is the Bio Of the second actor",
                            ProfilePictureURL="https://www.thisisdig.com/wp-content/uploads/2020/10/PP53CB-1.jpg",
                        },
                        new Actor()
                        {
                            FullName="Actor 2",
                            Bio="This is the Bio Of the second actor",
                            ProfilePictureURL=" https://th.bing.com/th/id/R.fd7eae56aabd609d7f2890012f70d0ba?rik=%2b3J%2bHB%2fA%2bYcPLw&riu=http%3a%2f%2fi1361.photobucket.com%2falbums%2fr661%2fvoteformost%2fman%2f01%2fStephen_Amell_zpsvrfs5ecy.jpg&ehk=FqHBDknDfm85ie7KO87CZWo%2b8TzT2EdJHMC4GX1et9c%3d&risl=&pid=ImgRaw&r=0"
                        },
                        new Actor()
                        {
                            FullName="Actor 3",
                            Bio="This is the Bio Of the second actor",
                            ProfilePictureURL="https://celebie.com/wp-content/uploads/2017/05/charlie.jpg",
                        },new Actor()
                        {
                            FullName="Actor 4",
                            Bio="This is the Bio Of the second actor",
                            ProfilePictureURL="https://th.bing.com/th/id/OIP.eh2ujwQQQMi1H9SqUdhpFwHaFj?pid=ImgDet&rs=1",
                        },
                };
            }
        } 
    }
}
