using MovieApplication.Models;
using MovieApplication.Realizations.interfaces;

namespace MovieApplication.Realizations.classes
{
    public class ProducerRealization : IProducerInfo
    {
        public IEnumerable<Producer> Producers {

            get
            {
                return new List<Producer>
                {
                        new Producer()
                        {
                        FullName="Producer 1",
                        Bio="This is a the Bio of the second  actor",
                        ProfilePictureURL="https://th.bing.com/th/id/R.ced43a6b4516c757f8459bc462090446?rik=0MXJ%2fRp9lMeu1w&riu=http%3a%2f%2fwww.aveleyman.com%2fGallery%2f2017%2fK%2f125122.jpg&ehk=K9U9IGPA5Odb3yzj0XOFHw34svudejqSlZpnFc3AeYI%3d&risl=&pid=ImgRaw&r=0"
                        },
                        new Producer()
                        {
                        FullName="Producer 2",
                        Bio="This is a the Bio of the second  actor",
                        ProfilePictureURL=" https://th.bing.com/th/id/OIP.fKtqRMg-yOXx3vsoZnWnvAHaEK?pid=ImgDet&rs=1"
                        },
                        new Producer()
                        {
                        FullName="Producer 3",
                        Bio="This is a the Bio of the second  actor",
                        ProfilePictureURL=" https://th.bing.com/th/id/OIP.t4zntqFLrAFKyVHqW-YwBAHaEc?pid=ImgDet&w=970&h=582&rs=1"
                        },
                        new Producer()
                        {
                        FullName="Producer 4",
                        Bio="This is a the Bio of the second  actor",
                        ProfilePictureURL="https://s3.r29static.com/bin/public/aef/0,0,2000,1050/x,80/1528832/image.jpg"
                        },
                        new Producer()
                        {
                        FullName="Producer 5",
                        Bio="This is a the Bio of the second  actor",
                        ProfilePictureURL="https://th.bing.com/th/id/R.cfbba5b70f56609ea2b8195369c93654?rik=6Ds4fD1qsMiXFA&riu=http%3a%2f%2fwallsdesk.com%2fwp-content%2fuploads%2f2016%2f09%2fPictures-of-Chris-Hemsworth.jpg&ehk=hJpoE9siUmmEL9JRteTiOfEoKVg2XYcRu2HbCimLxX4%3d&risl=&pid=ImgRaw&r=0"
                        },

                };
            }
        
        }
    }
}
