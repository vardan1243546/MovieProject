using MovieApplication.Models;
using MovieApplication.Realizations.interfaces;
using System.Security.Cryptography.Xml;

namespace MovieApplication.Realizations.classes
{
    public class MovieRealization:IMovieInfo
    {
        public IEnumerable<Movie> Movies
        {
            get
            {
                return new List<Movie>
                {
                    new Movie()
                        {
                            Name="Life",
                            Description="This is the Life Move description",
                            Price=39.50,
                            ImageURL="https://th.bing.com/th/id/OIP.AhHlJpjCej5cypIo4FmenwAAAA?pid=ImgDet&rs=1",
                            StartDate=DateTime.Now.AddDays(-10),
                            EndDate=DateTime.Now.AddDays(10),
                            CinemaId=3,
                             ProducerId=3,
                             MovieCategory=MovieCategory.Documental,
                        },
                        new Movie()
                        {
                            Name="The Shawshank Redemption",
                            Description="This is Shawshank Redemption description",
                            Price=29.50,
                            ImageURL="https://th.bing.com/th/id/OIP.1JKZ6OFoBbuEnNPQFQSDJgHaLi?pid=ImgDet&w=1000&h=1558&rs=1",
                            StartDate=DateTime.Now,
                            EndDate=DateTime.Now.AddDays(3),
                            CinemaId=1,
                            ProducerId=1,
                            MovieCategory=MovieCategory.Action,
                        },
                        new Movie()
                        {
                         Name="Ghost",
                         Description="This is the Ghost movie description",
                         Price=39.50,
                         ImageURL="https://th.bing.com/th/id/R.6897f12747beeff317002d66858bdcc7?rik=bwDxbS55P1zzwg&riu=http%3a%2f%2fcinemacrush.com%2fmedia%2fghost%2fw500%2fhQtKB7wU2BDAtdnpGSzFCoZjKie.jpg&ehk=h7DNUM57MTdDECURIiC78Bxgsa9OMjtY2lgSBG9C06I%3d&risl=&pid=ImgRaw&r=0",
                         StartDate=DateTime.Now,
                         EndDate=DateTime.Now.AddDays(7),
                         CinemaId=4,
                         ProducerId=4,
                        MovieCategory=MovieCategory.Horror,

                        },
                        new Movie()
                        {
                          Name="Race",
                          Description="This is the Race movie description",
                          Price=39.50,
                          ImageURL="https://th.bing.com/th/id/R.9cfbed6a1ad2a80344a708befc709284?rik=URDyJ6lP2XAg9Q&pid=ImgRaw&r=0",
                          StartDate=DateTime.Now.AddDays(-10),
                          EndDate=DateTime.Now.AddDays(-5),
                          CinemaId=1,
                          ProducerId=2,
                          MovieCategory=MovieCategory.Documental
                        },
                        new Movie()
                        {
                            Name="Scoob",
                            Description="This is the Scoob movie description",
                            Price=39.50,
                            ImageURL="https://th.bing.com/th/id/R.2db58921ee846acf2cc0dc81c30ed174?rik=aoIUMgLoU6PmpA&riu=http%3a%2f%2fwww.cinemadelsilenzio.it%2fimages%2ffilm%2fposter%2f9045_big.jpg&ehk=l41qmiBqw984bUP1uV%2fvm7ddODfTBVMeY5Q2zhQDcRM%3d&risl=&pid=ImgRaw&r=0",
                           StartDate=DateTime.Now.AddDays(-10),
                           EndDate=DateTime.Now.AddDays(-2),
                           CinemaId=1,
                           ProducerId=3,
                           MovieCategory=MovieCategory.Dramma
                        },  new Movie()
                        {
                            Name="Cold Soles",
                            Description="This is the Cold Soles description",
                            Price=39.50,
                            ImageURL="https://th.bing.com/th/id/OIP.lbkj3oUYNMfFt7TxrpwrUgAAAA?pid=ImgDet&rs=1",
                           StartDate=DateTime.Now.AddDays(3),
                           EndDate=DateTime.Now.AddDays(20),
                           CinemaId=1,
                           ProducerId=5,
                           MovieCategory=MovieCategory.Dramma
                        },
                };
            }
        }
    }
}
