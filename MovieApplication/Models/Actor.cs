using System.ComponentModel.DataAnnotations;

namespace MovieApplication.Models
{
    public class Actor
    {
        [Key]
        public int ActorId { get; set; }

        [Display(Name ="Profile Picture URL")]
        [Required(ErrorMessage ="Profile Picture is required")]
        public string ProfilePictureURL{ get; set; }

        [Display(Name = " Full Name ")]
        [Required(ErrorMessage ="Name is required")]
        public string FullName { get; set; }
        
        [Display(Name = "   Biography ")]
        [Required(ErrorMessage = "Biography is required")]
        public string Bio { get; set; }

        public List<Actor_Movie> Actor_Movies { get; set; }
    }
}
