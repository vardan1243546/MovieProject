using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;

namespace MovieApplication.Models
{
    public class Movie
    {
        [Key] public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }

        public string ImageURL { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }   

        public MovieCategory MovieCategory { get; set; }

        public List<Actor_Movie> Actor_Movies { get; set; }

        public int CinemaId { get; set; }

        [ForeignKey("CinemaId")]
        public Cinema Cinema { get; set; }  
        
        public int ProducerId { get; set; }

        [ForeignKey("ProducerId")]
        public  Producer Producer { get; set; }

    }
    public enum MovieCategory
    { 
       Action=1,
       Comedy,
       Dramma,
        Documental,
        Horror,
    }
}
