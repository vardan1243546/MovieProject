using MovieApplication.Models;
using MovieApplication.Realizations.interfaces;

namespace MovieApplication.Realizations.classes
{
    public class CinemaRealization:ICinemaInfo
    {
        public IEnumerable<Cinema> Cinemas
        {
            get
            {
                return new List<Cinema>
                {
                    new Cinema()
                      {
                         Name="Cinema 1 ",
                         Logo="https://www.logolynx.com/images/logolynx/ad/ad8dbcb4bd4b3a19c5de1e43cb6d2b4c.jpeg",
                         Description="This is the description of  the first cinema"
                      },new Cinema()
                      {
                         Name="Cinema 2 ",
                         Logo="https://th.bing.com/th/id/OIP.uJI49P-_UDutikqVSkx0wgHaGr?pid=ImgDet&rs=1",
                         Description="This is the description of  the first cinema"
                      },new Cinema()
                      {
                         Name="Cinema 3 ",
                         Logo="https://th.bing.com/th/id/OIP.vkwWxRkFqLMEjKwaw46WXQHaH0?pid=ImgDet&w=1599&h=1689&rs=1",
                         Description="This is the description of  the first cinema"
                      },new Cinema()
                      {
                         Name="Cinema 4 ",
                         Logo="https://th.bing.com/th/id/OIP.LRhUFcJ0Y4HG21F3s0pKQwHaHp?pid=ImgDet&w=600&h=620&rs=1",
                         Description="This is the description of  the first cinema"
                      },new Cinema()
                      {
                         Name="Cinema 5 ",
                         Logo="https://th.bing.com/th/id/OIP.embOVKnJI3kKXF29nyHqEAAAAA?pid=ImgDet&w=450&h=470&rs=1",
                         Description="This is the description of  the first cinema"
                      },

                };
            }
        }
    }
}
